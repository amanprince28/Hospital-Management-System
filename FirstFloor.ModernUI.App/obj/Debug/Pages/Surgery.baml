   M S B A M L   `   `   `  ����G  CModernUIDemo, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:FirstFloor.ModernUI.AppFirstFloor.ModernUI.App  5      +    %FirstFloor.ModernUI.App.Pages.Surgery   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      5app%clr-namespace:FirstFloor.ModernUI.App     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      N JFirstFloor.ModernUI, Version=1.0.6.0, Culture=neutral, PublicKeyToken=null0mui&http://firstfloorsoftware.com/ModernUI  5      $	��600��5      $	��600��5	      .��5      �    ContentRoot#��[  6     � DataContext  5   
   1   +FirstFloor.ModernUI.App.SampleFormViewModel  5      .+�5   
   �� $��
250,22,0,0q�6   $
��Left=�5      $	��Top=�5      $��Surgery Details��5      �� 5   
   $��	66,88,0,0q�6   $
��Left=�5      $	��Top=�5      $��Patient Name��5      �� 5   
   $��
66,116,0,0q�6   $
��Left=�5      $	��Top=�5      $��
Patient ID��5      �� 5   
   $��
66,144,0,0q�6   $
��Left=�5      $	��Top=�5      $!��Doctor's Name(Head Surgeon)��5       �� 5!   
   $��
66,172,0,0q�6   $
��Left=�5"      $	��Top=�5#      $��Doctor's ID(Head Surgeon)��5$      �� 5%   
   $��
66,200,0,0q�6   $
��Left=�5&      $	��Top=�5'      $�� ��5(      �� 5)   
   -   5         ��Name$ txtPatientName��5)      $	��220��5*      $��23��5+      $��
270,81,0,0q�5,      $
��Left=�5-      $	��Top=�5.       �� TextWrapping$
 Wrap=�52      ��5/      �� *P_name+ �� Mode$ TwoWay=� �� ValidatesOnDataErrors . 52      �� 53   
   -   5        $ txtPatientID��53      $	��220��54      $��23��55      $��270,109,0,0q�56      $
��Left=�57      $	��Top=�58      $
 Wrap=�5<      ��59      �� *P_id+$ TwoWay=� . 5<      �� 5=   
   -   5        $ 
txtDN_HODS��5=      $	��220��5>      $��23��5?      $��270,137,0,0q�5@      $
��Left=�5A      $	��Top=�5B      $
 Wrap=�5G      ��5C      �� *dhod+$ TwoWay=� . 5G      �� 5H   
   -   5        $ txtDID_HODS��5H      $	��220��5I      $��23��5J      $��270,165,0,0q�5K      $
��Left=�5L      $	��Top=�5M      $
 Wrap=�5Q      ��5N      �� *di_hod+$ TwoWay=� . 5Q      �� 5R   
   -   5        $ txtAssistantSurgeon��5R      $	��220��5S      $��23��5T      $��270,193,0,0q�5U      $
��Left=�5V      $	��Top=�5W      $
 Wrap=�5[      ��5X      �� *d_ass+$ TwoWay=� . 5[      �� 5\   
   $��
66,196,0,0q�6   $
��Left=�5]      $	��Top=�5^      $��Assistant Surgeons��5_      �� 5`   
   $��
66,224,0,0q�6   $
��Left=�5a      $	��Top=�5b      $��Nurses Names��5c      �� 5d   
   -   5        $ txtNursesName��5d      $	��220��5e      $��23��5f      $��270,221,0,0q�5g      $
��Left=�5h      $	��Top=�5i      $
 Wrap=�5m      ��5j      �� *nurse+$ TwoWay=� . 5m      7  1FirstFloor.ModernUI.Windows.Controls.ModernButton  5n   
   -   5        $��270,292,0,0q�5n      $
��Left=�5o      $	��Top=�5p      $��Submit Details��5r      �� 5s   
   $��
66,252,0,0q�6   $
��Left=�5t      $	��Top=�5u      $��Surgery Date��5v      (  "System.Windows.Controls.DatePicker  5w   
   -   5          Name$ SurgeryDate��5w      $	��220��5x      $��270,249,0,0q�5y      $
��Left=�5z      $	��Top=�5{      5}      5~      