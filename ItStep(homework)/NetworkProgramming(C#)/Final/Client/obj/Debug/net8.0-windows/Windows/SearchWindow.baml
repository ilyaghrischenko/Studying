   M S B A M L   `   `   `  ����A  =Client, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:Client.WindowsClient.Windows  5   	   !    Client.Windows.SearchWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:Client.Windows     5   	     � Title$  SearchWindow��5   	   $	��450��6   $	��800��6+   .��5	      �  � RowDefinitions 5
   
   �� 5      $
��0.1* �6   �� 5      $
��0.2* �6   �� 5      $
��0.1* �6   �� 5      $��2* �6   .+�5   
   � $��1��6    � ColumnDefinitions 5      �� 5      �� 5      $
��0.6* �6#   �� 5      $
��0.2* �6#   �� 5      $
��0.2* �6#   �� 5      .+�5      � $��1��6    5      �� 5      �� 5      .+�5       �� $��Search:��6   $��Center=�5!      �� 5"      -   5         ��Name$ SearchInput��5#      $��1��5"       �� TextAlignment$ Center=�5$      5%      �� 5'      -   5         ��Name$ SearchButton��5)      $��3��5'      $��Search��5(      5*      5+      (  "System.Windows.Controls.WebBrowser  5-   
   -   5          Name$ Browser��5.      $��3��5-      5/      50      51      