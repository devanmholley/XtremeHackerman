#include "MyForm.h"
#include <stdlib.h>

using namespace System;
using namespace System::Windows::Forms;

[STAThreadAttribute]
void Main(array<String^>^args) {
	Application::EnableVisualStyles();
	Application::SetCompatibleTextRenderingDefault(false);
	Title::MyForm form;
	Application::Run(%form);
}