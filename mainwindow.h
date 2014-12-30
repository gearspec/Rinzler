#ifndef MAINWINDOW_H
#define MAINWINDOW_H

#include <QMainWindow>
#include <QProcess>
#include <QTextEdit>
#include <QDateTime>
#include <QDirModel>
#include <QString>
#include <QFileInfo>
#include <QFile>
#include <QTextStream>
#include <QCoreApplication>
#include <QMessageBox>

namespace Ui {
class MainWindow;
}

class MainWindow : public QMainWindow
{
    Q_OBJECT

public:
    explicit MainWindow(QWidget *parent = 0);
    ~MainWindow();
    void append_to_display(QByteArray,QString);
    void send_to_terminal (QString);
    void get_drive_list();
    void select_drive();
    void create_file(QString,QString);

private slots:

    void on_bttnCleanAll_clicked();

    void on_bttnExit_clicked();

    void on_bttnRefreshDrive_clicked();

    void on_comboDriveList_currentTextChanged();

    void on_bttnClearOutput_clicked();

    void on_bttn_unhide_all_clicked();

    void on_bttn_del_shortcut_clicked();

    void on_bttn_del_autorun_clicked();

    void on_bttn_del_all_files_clicked();

    void on_bttn_Open_Drive_clicked();

    void on_bttn_del_all_vb_clicked();

    void on_bttn_del_all_ini_clicked();

    void on_bttn_disable_reg_clicked();

    void on_bttn_rem_exe_clicked();

    void on_bttn_enable_regedit_clicked();

    void on_bttn_enable_folder_option_clicked();

    void on_bttn_enable_taskmanager_clicked();

    void on_bttn_del_recycler_clicked();

    void on_bttn_about_clicked();

private:
    Ui::MainWindow *ui;
};

#endif // MAINWINDOW_H
