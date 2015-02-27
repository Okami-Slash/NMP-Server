#include "nmp.h"
#include "ui_nmp.h"

NMP::NMP(QWidget *parent) :
    QMainWindow(parent),
    ui(new Ui::NMP)
{
    ui->setupUi(this);
    connect (qApp, SIGNAL(aboutToQuit()), this, SLOT(NMPClose()));
}

NMP::~NMP()
{
    delete ui;
}


void NMP::on_pushButton_clicked()
{
    QString Directory = QApplication::applicationDirPath();
    QDesktopServices::openUrl(QUrl::fromLocalFile(Directory + "/nginx/www"));
}

void NMP::on_pushButton_2_clicked()
{
    QDesktopServices::openUrl(QUrl("http://localhost:8080", QUrl::TolerantMode));
}

void NMP::on_pushButton_3_clicked()
{
    QDesktopServices::openUrl(QUrl("http://localhost:8080/phpmyadmin/index.php", QUrl::TolerantMode));
}

void NMP::on_pushButton_4_clicked()
{
    QString Directory = QApplication::applicationDirPath();
    File(Directory + "/php/php.ini", "extension_dir =", Directory + "/php/ext/");
    File(Directory + "/php/php.ini", "mysql.default_socket =", Directory + "/mysql/var/mysql.sock");
    QStringList arguments;
    arguments << "-p" << Directory + "/nginx";
    nginx.startDetached(Directory + "/nginx/nginx", arguments);
    QStringList argumentsPHP;
    argumentsPHP << "-b" << "127.0.0.1:9000";
    php.startDetached(Directory + "/php/php-cgi", argumentsPHP);
    QStringList argumentsMYSQL;
    argumentsMYSQL << "--datadir=" + Directory + "/mysql/var/" << "--log-error=/usr/local/var/log/mysql.log";
    mysql.startDetached(Directory + "/mysql/bin/mysqld_safe", argumentsMYSQL);
    ui->pushButton_4->setIcon(QIcon(":/images/on.png"));
}

void NMP::NMPClose()
{
    system("pkill nginx");
    system("pkill mysqld");
    system("pkill php-cgi");
    nginx.close();
    php.close();
    mysql.close();
}

void NMP::File(QString Name, QString Data, QString NData)
{
    //QFile file(Directory + "/php/php.ini");
    QFile file(Name);
    if( ! file.open(QIODevice::ReadOnly))
    {
        return;
    }
    QString cont(file.readAll());
    QStringList conts = cont.split( "\n" );
    for( int i = 0; i < conts.count(); i++ )
    {
        QString & str = conts[i];
        if(str.startsWith(Data))
        {
            str = QString(Data + NData);
            break;
        }
    }
    file.close();
    if( ! file.open(QIODevice::WriteOnly))
    {
        return;
    }
    QTextStream text(&file);
    foreach(QString str, conts)
    {
        text << str << endl;
    }
    file.close();
}
