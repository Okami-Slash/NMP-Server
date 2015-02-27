#ifndef NMP_H
#define NMP_H

#include <QMainWindow>
#include <QDesktopServices>
#include <QUrl>
#include <QProcess>
#include <QDir>
#include <QMessageBox>
#include <QTextStream>

namespace Ui {
class NMP;
}

class NMP : public QMainWindow
{
    Q_OBJECT
    QProcess nginx;
    QProcess php;
    QProcess mysql;

public:
    explicit NMP(QWidget *parent = 0);
    ~NMP();

public slots:
    void NMPClose();
    void File(QString Name, QString Data, QString NData);

private slots:

    void on_pushButton_clicked();

    void on_pushButton_2_clicked();

    void on_pushButton_3_clicked();

    void on_pushButton_4_clicked();

private:
    Ui::NMP *ui;
};

#endif // NMP_H
