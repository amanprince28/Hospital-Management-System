   M S B A M L   `   `   `  ����G  CModernUIDemo, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:FirstFloor.ModernUI.AppFirstFloor.ModernUI.App  5      ,    &FirstFloor.ModernUI.App.Pages.Medicine   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      N JFirstFloor.ModernUI, Version=1.0.6.0, Culture=neutral, PublicKeyToken=null0mui&http://firstfloorsoftware.com/ModernUI  5      /app%clr-namespace:FirstFloor.ModernUI.App  5      .��5      �    ContentRoot#��[  6     � DataContext  5   
   1   +FirstFloor.ModernUI.App.SampleFormViewModel  5      .+�5   
   �� $��
146,30,0,0q�6   $
��Left=�5      $	��Top=�5      $��Medicine��5      �� 5   
   $��	20,93,0,0q�6   $
��Left=�5      $	��Top=�5      $��Medicine Name��5      �� 5   
   -   5         ��Name$ txtMedicineName��5      $	��217��5      $��
120,93,0,0q�5      $
��Left=�5      $	��Top=�5       �� TextWrapping$
 Wrap=�5      ��6&   �� *MedicineName+ �� Mode$ TwoWay=� �� ValidatesOnDataErrors . 7  1FirstFloor.ModernUI.Windows.Controls.ModernButton  5    
   -   5        $��120,171,0,0q�5       $
��Left=�5!      $	��Top=�5"      $	��Add��5$      �� 5%   
   $��
20,134,0,0q�6   $
��Left=�5&      $	��Top=�5'      $��Company Name��5(      �� 5)   
   -   5        $ txtcompanyname��5)      $	��217��5*      $��23��5+      $��120,131,0,0q�5,      $
��Left=�5-      $	��Top=�5.      $
 Wrap=�5/      ��6&   �� *CompanyName+$ TwoWay=� . 50      51      