   M S B A M L   `   `   `  ????B  >01_MVVM, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:_01_MVVM.View_01_MVVM.View  5   	   7 clr-namespace:_01_MVVM.ViewModel_01_MVVM.ViewModel  5   	   I)clr-namespace:_01_MVVM.ViewModel.Commands_01_MVVM.ViewModel.Commands  5   	   "    _01_MVVM.View.MainWindowView   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:_01_MVVM.View     5   	   6	viewmodel clr-namespace:_01_MVVM.ViewModel     5   	   =command)clr-namespace:_01_MVVM.ViewModel.Commands     5   	     ? Title$  
MainWindow??5
   	   $	??450??6   $	??800??6)    ? DataContext 5      ,   &_01_MVVM.ViewModel.MainWindowViewModel  5   
   .??5      ? .+?5   
   ?? $
??Left=?6   $??220,154,0,0q?6-    ?? TextWrapping$
 Wrap=?6B   $	??Top=?6q   $	??120??6?   ??6V   ?? *	Firstname+6?   ?? 5   
   $
??Left=?6   $??	220,0,0,0q?6-   $
 Wrap=?6@   $??Center=?6n   $	??120??6?   ??6T   ?? *
Lastname+6?   ?? 5   
   $
??Left=?6   $??220,254,0,0q?6/   $
??Wrap=?6D   $	??Top=?6r   $	??120??6?   ??6X   ?? *
Fullname+6?   ?? 5   
   $??Clear??6   $
??Left=?6!   $??265,104,0,0q?6<   $	??Top=?6Q   ??6i   ?? *ClearCommand+5      5      