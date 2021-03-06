; Script generated by the Inno Script Studio Wizard.
; SEE THE DOCUMENTATION FOR DETAILS ON CREATING INNO SETUP SCRIPT FILES!

#define MyAppName "PasswordGeneratorShareware"
#define MyAppVersion "1.0"
#define MyAppPublisher "ShamugiyaLG"
#define MyAppExeName "PasswordGeneratorShareware.exe"

[Setup]
; NOTE: The value of AppId uniquely identifies this application.
; Do not use the same AppId value in installers for other applications.
; (To generate a new GUID, click Tools | Generate GUID inside the IDE.)
AppId={{B3864158-0BD2-46E9-B03A-375FD0E39C92}
AppName={#MyAppName}
AppVersion={#MyAppVersion}
;AppVerName={#MyAppName} {#MyAppVersion}
AppPublisher={#MyAppPublisher}
DefaultDirName={pf}\{#MyAppName}
DefaultGroupName={#MyAppName}
LicenseFile=C:\Users\scham\Desktop\???\????\???????????? 3\PasswordGeneratorShareware\PasswordGeneratorShareware.lic
InfoAfterFile=C:\Users\scham\Desktop\???\????\???????????? 3\PasswordGeneratorShareware\ReadMe.txt
OutputDir=C:\Users\scham\Desktop\???\????\???????????? 3\PasswordGeneratorShareware\PasswordGeneratorShareware Setup
OutputBaseFilename=setup
SetupIconFile=C:\Users\scham\Desktop\???\????\???????????? 3\PasswordGeneratorShareware\PasswordGeneratorShareware.ico
Compression=lzma
SolidCompression=yes
Uninstallable=yes
UninstallDisplayIcon={app}\PasswordGeneratorShareware.ico

[Languages]
Name: "english"; MessagesFile: "compiler:Default.isl"
Name: "russian"; MessagesFile: "compiler:Languages\Russian.isl"

[Tasks]
Name: "desktopicon"; Description: "{cm:CreateDesktopIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked

[Files]
Source: "C:\Users\scham\Desktop\???\????\???????????? 3\PasswordGeneratorShareware\PasswordGeneratorShareware.exe"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\scham\Desktop\???\????\???????????? 3\PasswordGeneratorShareware\PasswordGeneratorShareware.hlp"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\scham\Desktop\???\????\???????????? 3\PasswordGeneratorShareware\PasswordGeneratorShareware.ico"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\scham\Desktop\???\????\???????????? 3\PasswordGeneratorShareware\PasswordGeneratorShareware.lic"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\scham\Desktop\???\????\???????????? 3\PasswordGeneratorShareware\ReadMe.txt"; DestDir: "{app}"; Flags: ignoreversion
; NOTE: Don't use "Flags: ignoreversion" on any shared system files

[Icons]
Name: "{group}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"
Name: "{group}\{cm:UninstallProgram,{#MyAppName}}"; Filename: "{uninstallexe}"
Name: "{commondesktop}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"; Tasks: desktopicon

[Run]
Filename: "{app}\{#MyAppExeName}"; Description: "{cm:LaunchProgram,{#StringChange(MyAppName, '&', '&&')}}"; Flags: nowait postinstall skipifsilent


