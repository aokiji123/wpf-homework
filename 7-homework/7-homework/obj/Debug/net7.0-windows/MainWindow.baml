   M S B A M L   `   `   `  ����E  A7-homework, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:_7_homework_7_homework  5   	       _7_homework.MainWindow   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:_7_homework     5   	     � Title$  Main Window��5   	   $	��720��6   $
��1280��6*   .��5	      �  � RowDefinitions 5
   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $��* �6   .+�5   
   �� $��0��6    �� Orientation$ 
Horizontal=�6"   $��Center=�6;   $��Center=�6X   .+�5      �� $��22 September, Thursday��6   $��10q�66   $��Center=�6B   $
��Bold"�5      $��24(�6*   
����ح�68   �� 5      $��Mark for another date��6   $��10q�65   
����ح�
�������6X   5      �� 5   
   $��1��6   $ Vertical=�6"   $
��Left=�69   $��10q�6T   .+�5      �� $D��>KN-P-201 (Development of applications using WinForms and GDI+)��6   $��5q�5      $��Center=�6#   $
��Bold"�6>   $��16(�6P   �� 5      $��Lesson topic: Containers��6   $��5q�68   $��Center=�6C   $��14(�6^   5      �� 5   
   -   5        $��
MyListView��5   ,   $��2��6   $��10q�6    ��6>   �� *
Students+��5      �� 5       �� 
TargetType" ��6   .�5      ��  �� Property � �� �� Value$ Stretch=�6C   5        �� View 5"      �� 5#      .P�5$      �� $	��No.��6%    �� Width$ 50��62    �� CellTemplate 5%      �� 5&      .R�5'   "   �� 	 �� TextAlignment$	 Center=�6D   ��6,   �� *Number+6D   5(      5*      �� 5,      $��Student��6%   $	 350��66    5-      �� 5.      .R�5/   "   �� $ 
Horizontal=�6-   $��Stretch=�6F   .+�50   &   �� $��50��6,   $��50��67   $;��5https://cdn-icons-png.flaticon.com/512/149/149071.png��6C   �� 51   &   $
��Bold"�6F   $��10,0,0,0q�6X   $��Center=�6j   ��60   �� *Name+6j   52   #   53      55      �� 57      $��
Attendance��6%   $	 150��69    58      �� 59      .R�5:   "   �� $ 
Horizontal=�6-   $��Center=�6F   .+�5;   &   	� $��2q�6o   
 	� 	GroupName
 62   �� *Number+ d� 	IsChecked 6O   �� *	IsPresent+6o   	� 5<   &   $��2q�6l   
 62   �� *Number+ 6O   �� *IsLate+6l   	� 5=   &   $��2q�6n   
 62   �� *Number+ 6O   �� *
IsAbsent+6n   5>   #   5?      5A      �� 5C      $��
Test Grade��6%   $	 150��69    5D      �� 5E      .R�5F   "   �� $��Center=�6G   $	 Center=�6d   
���� ��
������� �� Padding$ 2q�5G   ?   $	��0,2q�6K   ��5F   ,   �� *	ExamGrade+��5H   &   �� 5I   *   " ��60    �� Triggers 5J   .   �� 5K   2    �� Binding 6>   �� *	ExamGrade+ �� Value -6\   .a�5L   6   ��  � ��
 ���� 6S   �� 5M   6    � ��
 �   �6S   5N   3   5P   +   5R   #   5S      5U      �� 5W      $��Lesson Grade��6%   $	 150��6;    5X      �� 5Y      .R�5Z   "   �� $��Center=�6I   $	 Center=�6f   
��� � �
�������$ 2q�5[   >   $	��0,2q�6J   ��5Z   ,   �� *LessonGrade+5[   J   5\      5^      �� 5`      $��Comments��6%   $	 200��67    5a      �� 5b      .R�5c   "   �� $��Add Comment��6)   $��Center=�6?   5d      5f      5g      5i      5j      5k      