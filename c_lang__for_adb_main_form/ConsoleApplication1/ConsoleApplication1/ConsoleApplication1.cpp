// ConsoleApplication1.cpp : 콘솔 응용 프로그램에 대한 진입점을 정의합니다.
//

#include "stdafx.h"
//#pragma comment(linker,"/subsystem:\"windows\" \ /entry:\"mainCRTStartup\"")

//#define _WIN32_WINNT 0x0500

//#define BUFSIZE 512
//int tmain(int argc, _TCHAR* argv[])
int APIENTRY _tWinMain(HINSTANCE hInstance, HINSTANCE hPrevInstance, LPTSTR lpCmdLine,int nCmdShow)
{
	

	HWND hWndConsole = GetConsoleWindow();
   ShowWindow(hWndConsole, SW_HIDE );

	std::cout<<"Made by hwang씨(imscs21)"<<std::endl;
   printf("Made by hwang씨(imscs21) \n");
   printf("http://hsh97.tistory.com/");
	system("adb\\adb.exe start-server");
	system("adb\\adb.exe devices > temp1.tmp");
	//system("PAUSE");
	//\//

	return 0;
	

}