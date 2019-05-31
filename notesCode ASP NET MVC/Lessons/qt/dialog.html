
        <center><h1>Діалогові вікна</h1></center>
        <br>
        <p>Програма, показана на малюнку, є результатом створення власного діалогового вікна. При запуску на екрані вікно з кнопкою Press Me (Натисни мене), натискання на яку відображає діалогове вікно введення імені First Name (Ім'я) і прізвища Last Name (Прізвище).</p>
        <pre><code class="cpp">// Файл main.cpp   

       #include < QApplication >   

       #include "StartDialog.h"   

       int main(int argc, char** argv)   

       {   

       QApplication app(argc, argv);   

       StartDialog startDialog;   

       startDialog.setMinimumWidth(200);   

       startDialog.show();   

       return app.exec();   

       }   </code></pre>
        <p>У файлі main.cpp створюється віджет класу StartDialog, призначений для запуску діалогового вікна.</p>
        <br><img src="images/dialog.png"><br>
        <pre><code class="cpp">// Файл StartDialog.h   

       #ifndef _StartDialog_h_   

       #define _StartDialog_h_   

       #include < QtGui >   

       #include "InputDialog.h"   

       class StartDialog : public QPushButton {   

       Q_OBJECT   

       public:   

       StartDialog(QWidget* pwgt = 0) : QPushButton("Press Me", pwgt)   

       {   

            connect(this, SIGNAL(clicked()), SLOT(slotButtonClicked()));   

       }   

       public slots:   

       void slotButtonClicked()   

       {   

       InputDialog* pInputDialog = new InputDialog;   

       if (pInputDialog->exec() == QDialog::Accepted) {   

            QMessageBox::information(0,"Information","First Name: "+ pInputDialog->firstName()+ "\nLast Name: "+ pInputDialog->lastName());   

       }   

       delete pInputDialog;   

       }   

       };   

       #endif //_StartDialog_h_   </code></pre>
        <p>Клас StartDialog успадкований від класу кнопки натискання. Сигнал clicked () з'єднується в методі connect () зі слотом slotButtonClicked (). У цьому слоті створюється об'єкт діалогового вікна InputDialog, який не має предка.</p>
        <p>Примітка: Діалогові вікна, що не має предка, будуть центрироваться по екрану. Вікна з предками будуть відцентровані щодо предка.</p>
        <p>В операторі if проводиться запуск діалогового вікна. Після його закриття управління передається основній програмі і метод exec () повертає значення, утримуючи користувачем кнопки. У тому випадку, якщо користувачем була натиснута кнопка Ok, відбудеться відображення інформаційного вікна з введеними в діалоговому вікні даними. По завершенні методу діалогове вікно потрібно видалити самому, так як у нього немає предка, який подбає про це.</p>
       <pre><code class="cpp"> // Файл InputDialog.h   

       #ifndef _InputDialog_h_   

       #define _InputDialog_h_   

       #include < QDialog >   

       class QLineEdit;   

       class InputDialog : public QDialog {   

       Q_OBJECT   

       private:   

            QLineEdit* m_ptxtFirstName;   

            QLineEdit* m_ptxtLastName;   

       public:   

            InputDialog(QWidget* pwgt = 0);   

            QString firstName() const;   

            QString lastName () const;   

       };   

       #endif //_InputDialog_h_   </code></pre>
        <p>Для створення свого власного діалогового вікна потрібно успадкувати клас QDialog. Клас InputDialog містить два атрибути - покажчики m_ptxtFirstName і m_ptxtLastName на віджети однострочного текстового поля, і два методи, які повертають вміст цих полів - firstName () і lastName ().</p>
        <pre><code class="cpp">// Файл InputDialog.cpp   

       #include < QtGui >   

       #include "InputDialog.h"   

       InputDialog::InputDialog(QWidget* pwgt/*= 0*/) : QDialog(pwgt, Qt::WindowTitleHint | Qt::WindowSystemMenuHint)   

       {   

           m_ptxtFirstName = new QLineEdit;   

           m_ptxtLastName = new QLineEdit;   

           QLabel* plblFirstName = new QLabel("&First Name");   

           QLabel* plblLastName = new QLabel("&Last Name");   

           plblFirstName->setBuddy(m_ptxtFirstName);   

           plblLastName->setBuddy(m_ptxtLastName);   

           QPushButton* pcmdOk = new QPushButton("&Ok");   

           QPushButton* pcmdCancel = new QPushButton("&Cancel");   

           connect(pcmdOk, SIGNAL(clicked()), SLOT(accept()));   

           connect(pcmdCancel, SIGNAL(clicked()), SLOT(reject()));   

           //Layout setup   

           QGridLayout* ptopLayout = new QGridLayout;   

           ptopLayout->addWidget(plblFirstName, 0, 0);   

           ptopLayout->addWidget(plblLastName, 1, 0);   

           ptopLayout->addWidget(m_ptxtFirstName, 0, 1);   

           ptopLayout->addWidget(m_ptxtLastName, 1, 1);   

           ptopLayout->addWidget(pcmdOk, 2,0);   

           ptopLayout->addWidget(pcmdCancel, 2, 1);   

           setLayout(ptopLayout);   

       }   </code></pre>
        <p>За замовчуванням область заголовку вікна містить кнопку?, Що служить для отримання докладної інформації про призначення віджетів.</p>
        <p>У нашому прикладі я вирішив знехтувати нею - для цього необхідно встановити прапори вікна, тому другим параметром передаються прапори Qt :: WindowTitleHint і Qt :: WindowSystemMenuHint, перший встановлює заголовок вікна, а другий - додає системне меню з можливістю закриття вікна.</p>
        <p>Модальне діалогове вікно завжди має містити кнопку Cancel (Скасувати). Сигнали clicked () кнопок Ok і Cancel (Скасування) з'єднуються зі слотами accept () і rejected () відповідно. Це робиться для того, щоб метод exec () повертав при натисканні кнопки Ok значення QDialog :: Accepted, а при натисканні на кнопку Cancel (Скасувати) - значення QDialog :: Rejected.</p>
        <pre><code class="cpp"> QString InputDialog::firstName() const   
        {   
            return m_ptxtFirstName->text();   
        }   </code></pre>
        <p>Метод firstName () повертає введене користувачем ім'я:</p>
        <pre><code class="cpp">  QString InputDialog::lastName() const   
        {   
            return m_ptxtLastNanie->text ();   
        }   </code></pre>
        <p>Метод lastName () повертає введену користувачем прізвище.</p>
        <script type="text/javascript">hljs.initHighlightingOnLoad();</script>
      