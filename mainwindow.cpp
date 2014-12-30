#include "mainwindow.h"
#include "ui_mainwindow.h"


QString driveSelection;

MainWindow::MainWindow(QWidget *parent) :
    QMainWindow(parent),
    ui(new Ui::MainWindow)
{
    ui->setupUi(this);
    this->setFixedSize(946,635);

    ui->lbl_rinzler_site->setTextInteractionFlags(Qt::TextBrowserInteraction);
    ui->lbl_rinzler_site->setOpenExternalLinks(true);

    ui->lbl_gnu->setTextInteractionFlags(Qt::TextBrowserInteraction);
    ui->lbl_gnu->setOpenExternalLinks(true);

    ui->lbl_fb->setTextInteractionFlags(Qt::TextBrowserInteraction);
    ui->lbl_fb->setOpenExternalLinks(true);

    ui->lbl_beer->setTextInteractionFlags(Qt::TextBrowserInteraction);
    ui->lbl_beer->setOpenExternalLinks(true);

    get_drive_list(); // get drives list when the Main Window Loads.
}

MainWindow::~MainWindow()
{
    delete ui;
}

void MainWindow::append_to_display(QByteArray output,QString command) //send pipe output to display
{
    QDate date = QDate::currentDate();
    QTime time = QTime::currentTime();

    ui->textEdit->moveCursor(QTextCursor::End);
    ui->textEdit->insertPlainText("-------------------\n"+date.toString()+" | "+time.toString()+"\nRunning Command : "+command+"\n---------------------------------\n");
    ui->textEdit->insertPlainText(output);
    ui->textEdit->moveCursor(QTextCursor::End);
}

void MainWindow::send_to_terminal(QString command)  // Send Command to Terminal
{
    QProcess *process=new QProcess;
    process->start(command);
    bool completionConfirm = process->waitForFinished();

    if (completionConfirm == true)                  // process failure/success confirmation
    {
        ui->textEdit->moveCursor(QTextCursor::End);
        ui->textEdit->insertPlainText(" :)  Operation Executed Successfully\n");
    }
    else
    {
        ui->textEdit->moveCursor(QTextCursor::End);
        ui->textEdit->insertPlainText(" :(  Operation Execution Failure !! Are you root/admin ?\n");
    }

    QByteArray output = process->readAll();
    process->close();
    delete process;
    append_to_display(output,command);
}

void MainWindow::on_bttnCleanAll_clicked()
{
                    ui->textEdit->moveCursor(QTextCursor::End);
                    ui->textEdit->insertPlainText("Starting One Click Clean");

                    on_bttn_unhide_all_clicked();
                    on_bttn_del_shortcut_clicked();
                    on_bttn_del_autorun_clicked();
                    on_bttn_del_all_vb_clicked();
                    on_bttn_del_all_ini_clicked();
                    on_bttn_del_recycler_clicked();
                    on_bttn_Open_Drive_clicked();

                    ui->textEdit->moveCursor(QTextCursor::End);
                    ui->textEdit->insertPlainText("Once Click Clean has finished. Please select Explore to view your drive");

}

void MainWindow::get_drive_list()
{
    QDirModel *model = new QDirModel(this);
    ui->comboDriveList->setModel(model);
    ui->comboDriveList->setCurrentIndex(ui->comboDriveList->count()-1); //by default select the last drive found.
}

void MainWindow::on_bttnExit_clicked()
{
    QCoreApplication::quit();
}

void MainWindow::on_bttnRefreshDrive_clicked()
{
    get_drive_list();
    ui->textEdit->moveCursor(QTextCursor::End);
    ui->textEdit->insertPlainText("Drive List Reloaded\n-------------------------");
}

void MainWindow::select_drive()
{
    ui->comboDriveList->currentIndex();
    driveSelection = ui->comboDriveList->currentText();
}

void MainWindow::on_comboDriveList_currentTextChanged()
{
    select_drive();
}

void MainWindow::on_bttnClearOutput_clicked()
{
    ui->textEdit->clear();
    ui->textEdit->setText("Cleared\n-------------");
}

void MainWindow::on_bttn_unhide_all_clicked()
{
    send_to_terminal ("cmd.exe /c "+driveSelection+" & dir /a & attrib *. -h -s /s /d");
}

void MainWindow::on_bttn_del_shortcut_clicked()
{
    send_to_terminal ("cmd.exe /c "+driveSelection+" & DEL /F /S /Q /A *.lnk");
}

void MainWindow::on_bttn_del_autorun_clicked()
{
    send_to_terminal ("cmd.exe /c "+driveSelection+" & DEL /F /S /Q /A autorun.inf");
}

void MainWindow::on_bttn_del_all_files_clicked()
{
    send_to_terminal ("cmd.exe /c "+driveSelection+" & DEL /F /S /Q /A *.*");
}

void MainWindow::on_bttn_Open_Drive_clicked()
{
    send_to_terminal ("cmd.exe /c "+driveSelection+" & explorer .");
}

void MainWindow::on_bttn_del_all_vb_clicked()
{
    send_to_terminal ("cmd.exe /c "+driveSelection+" & DEL /F /S /Q /A *.vba & DEL /F /S /Q /A *.vbs & DEL /F /S /Q /A *.vbe");
}

void MainWindow::on_bttn_del_all_ini_clicked()
{
    send_to_terminal ("cmd.exe /c "+driveSelection+" & DEL /F /S /Q /A *.ini");
}

void MainWindow::on_bttn_disable_reg_clicked()
{
    create_file("rinzler_disable_autorun.reg","Windows Registry Editor Version 5.00\r\n;Created by Sayem Chaklader\r\n[HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer]\r\n\"NoDriveTypeAutoRun\"=dword:000000ff");
    send_to_terminal ("regedit /c rinzler_disable_autorun.reg");
}
void MainWindow::create_file(QString fileName, QString content)
{
    QFile file(fileName);
    if (!file.open(QIODevice::WriteOnly | QIODevice::Text)){return;}
    else
    {
        QTextStream out(&file);
        out << content;
        file.close();
    }
}

void MainWindow::on_bttn_rem_exe_clicked()
{
    send_to_terminal ("cmd.exe /c "+driveSelection+" & DEL /F /S /Q /A *.exe");
}

void MainWindow::on_bttn_enable_regedit_clicked()
{
    create_file("rinzler_enable_registry.bat","echo Windows Registry Editor Version 5.00>Enable.reg\r\necho >>Enable.reg\r\necho [HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System]>>Enable.reg\r\necho \"DisableRegistryTools\"=dword:00000000>>Enable.reg\r\nregedit.exe /s Enable.reg\r\ndel /f Enable.reg\r\nexit");
    send_to_terminal ("cmd.exe /c rinzler_enable_registry.bat");
}

void MainWindow::on_bttn_enable_folder_option_clicked()
{
    create_file("enable_folder_option.bat","echo Windows Registry Editor Version 5.00>Enable.reg\r\necho >>Enable.reg\r\necho [HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer]>>Enable.reg\r\necho \"NoFolderOptions\"=dword:000000000>>Enable.reg\r\nregedit.exe /s Enable.reg\r\ndel /f Enable.reg\r\nexit");
    send_to_terminal ("cmd.exe /c enable_folder_option.bat");
}

void MainWindow::on_bttn_enable_taskmanager_clicked()
{
    create_file("rinzler_restore_taskmanager.reg","Windows Registry Editor Version 5.00\r\n;Created by Sayem Chaklader\r\n[HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System] “DisableTaskMgr” =dword:00000000");
    send_to_terminal ("regedit /c rinzler_restore_taskmanager.reg");
}

void MainWindow::on_bttn_del_recycler_clicked()
{
    send_to_terminal ("cmd.exe /c "+driveSelection+" & DEL /F /S /Q /A thumbs.db & DEL /F /S /Q /A RECYCLER.exe");
}

void MainWindow::on_bttn_about_clicked()
{
    QMessageBox msgBox;
    msgBox.setText("Developed By Sayem Chaklader, CS, IUB. http://www.nodesreopen.com\ngearspec at gmail.com\nLast Updated: 25th Dec 2014. V2.0\nOpen Source Software, Bangladesh.\nRinzler: A little tool to keep us safe from infecting malware\nThis software is under GNU GPL 3.0 & was written using C++ on Linux, for Windows");
    msgBox.exec();
}
