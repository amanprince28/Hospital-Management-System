   M S B A M L   `   `   `  ����G  CModernUIDemo, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:FirstFloor.ModernUI.AppFirstFloor.ModernUI.App  5      +    %ModernUINavigationApp3.Pages.AddAdmin   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      5app%clr-namespace:FirstFloor.ModernUI.App     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      N JFirstFloor.ModernUI, Version=1.0.6.0, Culture=neutral, PublicKeyToken=null0mui&http://firstfloorsoftware.com/ModernUI  5      .��5      �� .��5   
   �� $	��200��6   .+�5      �� $��0,20,0,8q�6   $��Center=�5         Heading2#��[  5      $��Add New Admin��5      �� 5      -   5          ��Name$
  Form��5      $��0,30,0,4q�5      $��Center=�5       �� Orientation$ Vertical=�5       � DataContext 5      1   +FirstFloor.ModernUI.App.SampleFormViewModel  5       � 	Resources 5!       �� 
TargetType �� Property �� Value �� BasedOn��%�  '��       '�� �     7��'�� $    7��'	� r    7	��� 5"      " ��6   .�5#      ��  �@��Orientation$ 
Horizontal=�68   �� 5$       � ��$ 0,0,0,4q�63   5%      �� 5&      8   " ��6F   .�5'      ��  � ��$	 100��62   �� 5(       � ��$ 0,0,0,4q�63   �� 5)       � ��$ Center=�6>   5*      �� 5+      8   " ��6I   .�5,      ��  � ��$	 0,3q�64   5-      �� 5.      8   " 	�6L   .�5/      ��  � ��$	 0,3q�64   50      51      .+�53      �� .+�54      �� $��	Full Name��6    �� Target 60   �� 	 �� ElementName$	 txtFullName���� 55      -   5        
 ��Name$
 txtFullName��55      $	��150��56      ��57      �� *
FullName+ �� Mode$ TwoWay=� �� ValidatesOnDataErrors . 5:      �� 5;      .+�5<      �� $��Registration Id��6    66   �� $	 txtRegistrationId���� 5=      -   5        $
 txtRegistrationId��5=      $	��150��5>      ��5?      �� *RegistrationId+$ TwoWay=� . 5B      �� 5C      .+�5D      �� $��	User Name��6    60   �� $	 txtRegistrationId���� 5E      -   5        $
 txtUserName��5E      $	��150��5F      ��5G      �� *
UserName+$ TwoWay=� . 5J      �� 5K      .+�5L      �� $��Password��6    6/   �� $	 txtPassword��G� 5M      -   5         G�Name$ txtPassword��5M   "   $	��150��67   5N      �� 5O      .+�5P      �� $��Gender��6    6-   �� $	 RadioGendeMale���� 5Q      -   5         ��Name$ comboboxGender��5Q      $	��150��67   .@�5R      �� $
��Male��6'   �� 5S      $��Female��6'   5T      5U      �� 5V      .+�5W      �� $��
Contact No��6    61   �� $	 txtContactNo���� 5X      -   5        $
 txtContactNo��5X      $	��150��5Y      ��5Z      �� *	ContactNo+$ TwoWay=� . 5]      �� 5^      .+�5_      �� $��Email Id��6    6/   �� $	 
txtEmailId���� 5`      -   5        $
 
txtEmailId��5`      $	��150��5a      ��5b      �� *	EmailId+$ TwoWay=� . 5e      �� 5f      .+�5g      �� $��Address��6    6.   �� $	 
txtAddress���� 5h      -	   5        $
 
txtAddress��5h      $	��150��62   ��5i      �� *Common+$ TwoWay=� . 5l      �� 5m      �� 5o      -
   5         ��Name$ Submitbutton��5o      $��
100,16,0,0q�5p      $
��Left=�5q      $��Submit��5s      5t      5u      5v      5w      