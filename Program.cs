/* SoftOne Version 6.0 */

using System.Diagnostics;

/*Change PaletteName to options:
  PaletteName=Default
  PaletteName=Blue
  PaletteName=Dark
  PaletteName=Soft Series 5
  PaletteName=Soft Series 5 Dark
*/
String configFile = "[CONFIG]\nModeLess=0\nEnterAsTab=1\nBoldSelection=0\nCaptionsOnRight=0\nNoBarTitles=0\nBarOnBottom=0\nSelOnEdit=0\nFitGridColumns=0\nViewGridZeroNumbers=0\nAutoShowGridEditor=1\nWebLook=0\nLeftWebMenuIcons=0\nChangeFieldAfterEdit=0\nFirstColumnOnInsert=0\nConfirmDeletion=0\nRepeatedEntry=1\nPopupEditing=0\nAutoStackPopup=0\nAutoNewBtn=0\nAutoChangePrintFontSize=0\nSingleDBConnection=0\nGreekCalendar=0\nTypeMatic=1\nCancelWordWrap=0\nScheduler=1\nSupportConsole=1\nAutoSearch=1\nPrintColors=1\nSingeClickOpenMenu=1\nPrintLines=1\nScreenPrtColors=1\nScreenPrtLines=1\nDBUserMenu=1\nAskOnClose=1\nRemoteExecuteOFF=0\nHasReminder=0\nDisableFastPasteFromClbrd=1\nIsMainMenuOpen=1\nIsTaskMenuOpen=0\nIsTabRap=0\nSelectorDefaultSort=0\nPopupAlert=1\nBrowserMasterDetail=1\nKeepActiveBrFilters=0\nEnableGridSort=1\nAllowMultipleGroupExpansion=1\nSelBufs=15\nNumbersFormat=0\nViewDatesFormat=0\nNumbersDot=0\nKeyboardDelay=0\nINetConnTimer=0\nTaxPrinterID=0\nAutoSearchLen=3\nSignBComPort=0\nDefTheme=-1\nMailType=0\nTypeSignB=0\nSelectedFont=0\nSearchEngine=0\nMailSecurity=0\nComboTimeFormat=2\nPrintTemplate=0\nSMSProvider=105\nSMSViber=0\nSelectorLines=10\nMailSMTPSecurity=0\nIsMegaMenu=1\nFXextUI=1\nUpdateUrl=\nUpdateDirectory=\nSupportProxy=\nPopServer=\nPopPort=110\nSMTPServer=\nSmtpPort=25\nMailAddr=\nUserName=\nPassword=\nSignBIPAddress=\nSMSProviderName=\nSMSHeader=\nSMSUsername=\nSMSPassword=\nSMSUrl=\nUserDefineFont=\nSMTPUserName=\nSMTPPassword=\nSkinName=Softone\nPaletteName=Blue\n[KEYBOARD]\nNew=Ctrl+N\nView=F2\nDelete=Ctrl+D\nSave=Ctrl+S\nPrint=Ctrl+P\nList=F3\nSelector=F7\nNextPanel=F6\nNextPg=Ctrl+PgDn\nPrevPg=Ctrl+PgUp\nNext=Ctrl+Right\nPrev=Ctrl+Left\nNextJob=Ctrl+F6\nPrevJob=Shift+Ctrl+F6\nHyperView=Alt+K\nHyperNew=Alt+N\nHyperMenu=Shift+F10\nGlobalSearch=Ctrl+F\n";

String pathToCFG = "C:\\Users\\username\\AppData\\Roaming\\SoftOne\\XPLORER.CFG";
System.IO.File.WriteAllText(pathToCFG, configFile);

String PathToSoftoneInstall = "C:\\Program Files (x86)\\SoftOne\\Soft1\\xplorer.exe";
String Paramet = "/host:host.gr /xextui";
Process.Start(PathToSoftoneInstall, Paramet);
