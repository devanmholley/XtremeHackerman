#pragma once
#include <stdlib.h>
namespace StartMenu {

	using namespace System;
	using namespace System::ComponentModel;
	using namespace System::Collections;
	using namespace System::Windows::Forms;
	using namespace System::Data;
	using namespace System::Drawing;
	using namespace System::Diagnostics;

	/// <summary>
	/// Summary for MyForm
	/// </summary>
	public ref class MyForm : public System::Windows::Forms::Form
	{
	public:
		MyForm(void)
		{
			InitializeComponent();
			//
			//TODO: Add the constructor code here
			//
		}

	protected:
		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		~MyForm()
		{
			if (components)
			{
				delete components;
			}
		}
	private: System::Windows::Forms::Button^  button1;
	private: System::Windows::Forms::Button^  button2;
	private: System::Windows::Forms::Button^  button3;
	private: System::Windows::Forms::Button^  button4;
	private: System::Windows::Forms::Button^  button5;
	private: System::Windows::Forms::Button^  button6;
	protected:

	private:
		/// <summary>
		/// Required designer variable.
		/// </summary>
		System::ComponentModel::Container ^components;

#pragma region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		void InitializeComponent(void)
		{
			this->button1 = (gcnew System::Windows::Forms::Button());
			this->button2 = (gcnew System::Windows::Forms::Button());
			this->button3 = (gcnew System::Windows::Forms::Button());
			this->button4 = (gcnew System::Windows::Forms::Button());
			this->button5 = (gcnew System::Windows::Forms::Button());
			this->button6 = (gcnew System::Windows::Forms::Button());
			this->SuspendLayout();
			// 
			// button1
			// 
			this->button1->Location = System::Drawing::Point(-2, 612);
			this->button1->Name = L"button1";
			this->button1->Size = System::Drawing::Size(75, 23);
			this->button1->TabIndex = 0;
			this->button1->Text = L"Start";
			this->button1->UseVisualStyleBackColor = true;
			this->button1->Click += gcnew System::EventHandler(this, &MyForm::Start_Click);
			// 
			// button2
			// 
			this->button2->Location = System::Drawing::Point(-2, 583);
			this->button2->Name = L"button2";
			this->button2->Size = System::Drawing::Size(75, 23);
			this->button2->TabIndex = 1;
			this->button2->Text = L"File Manager";
			this->button2->UseVisualStyleBackColor = true;
			this->button2->Click += gcnew System::EventHandler(this, &MyForm::FileManager_Click);
			// 
			// button3
			// 
			this->button3->Location = System::Drawing::Point(99, 612);
			this->button3->Name = L"button3";
			this->button3->Size = System::Drawing::Size(75, 23);
			this->button3->TabIndex = 2;
			this->button3->Text = L"Restart";
			this->button3->UseVisualStyleBackColor = true;
			this->button3->Click += gcnew System::EventHandler(this, &MyForm::Restart_Click);
			// 
			// button4
			// 
			this->button4->Location = System::Drawing::Point(189, 612);
			this->button4->Name = L"button4";
			this->button4->Size = System::Drawing::Size(75, 23);
			this->button4->TabIndex = 3;
			this->button4->Text = L"Shutdown";
			this->button4->UseVisualStyleBackColor = true;
			this->button4->Click += gcnew System::EventHandler(this, &MyForm::Shutdown_Click);
			// 
			// button5
			// 
			this->button5->Location = System::Drawing::Point(-2, 554);
			this->button5->Name = L"button5";
			this->button5->Size = System::Drawing::Size(75, 23);
			this->button5->TabIndex = 4;
			this->button5->Text = L"Internet Browser";
			this->button5->UseVisualStyleBackColor = true;
			this->button5->Click += gcnew System::EventHandler(this, &MyForm::InternetBrowser_Click);
			// 
			// button6
			// 
			this->button6->Location = System::Drawing::Point(-2, 525);
			this->button6->Name = L"button6";
			this->button6->Size = System::Drawing::Size(75, 23);
			this->button6->TabIndex = 5;
			this->button6->Text = L"Task Manager";
			this->button6->UseVisualStyleBackColor = true;
			this->button6->Click += gcnew System::EventHandler(this, &MyForm::TaskManager_Click);
			// 
			// MyForm
			// 
			this->AutoScaleDimensions = System::Drawing::SizeF(6, 13);
			this->AutoScaleMode = System::Windows::Forms::AutoScaleMode::Font;
			this->ClientSize = System::Drawing::Size(1457, 638);
			this->Controls->Add(this->button6);
			this->Controls->Add(this->button5);
			this->Controls->Add(this->button4);
			this->Controls->Add(this->button3);
			this->Controls->Add(this->button2);
			this->Controls->Add(this->button1);
			this->Name = L"Xtreme Hackerman";
			this->Text = L"Xtreme Hackerman";
			this->ResumeLayout(false);
			button2->Visible = false; //Hides each button at the start.
			button3->Visible = false;
			button4->Visible = false;
			button5->Visible = false;
			button6->Visible = false;
		}
#pragma endregion
	private: System::Void Start_Click(System::Object^  sender, System::EventArgs^  e) {
		 button1 =  (button1, button2, button3, button4, button5, button6);// Makes the start button have access to listing the other button on call.
		 button2->Visible = true;//Turns the visibility of each program on when the start button is pressed.
		 button3->Visible = true;
		 button4->Visible = true;
		 button5->Visible = true;
		 button6->Visible = true;
			

		

		 
	}
	private: System::Void FileManager_Click(System::Object^  sender, System::EventArgs^  e) {
		
		
	}
	private: System::Void Restart_Click(System::Object^  sender, System::EventArgs^  e) {
}
	private: System::Void Shutdown_Click(System::Object^  sender, System::EventArgs^  e) {
	exit(0);
}
	private: System::Void TaskManager_Click(System::Object^  sender, System::EventArgs^  e) {
}
	private: System::Void InternetBrowser_Click(System::Object^  sender, System::EventArgs^  e) {
}
};
}
