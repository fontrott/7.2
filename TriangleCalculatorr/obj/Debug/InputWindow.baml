   M S B A M L   `   `   `  ����  TriangleCalculatorr%    TriangleCalculatorr.InputWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  Input��5   	   $	��360��6   $	��322��6$    � WindowStartupLocation$ CenterScreen=�60    � 
ResizeMode$ NoResize=�6U   .��5      �  � ColumnDefinitions 5   
   �� 5      $��* �6    � RowDefinitions 5	   
   �� 5
      $	��100 �6   .+�5   
   �� $��19,0,10,-80q�6   $��Images/Image1.png��6%   $
��Fill=�6@   $	��188��6O   $��Bottom=�6\   �� 5   
   $��Side A:��6   $��
13,0,0,-71q�6"   $��26��66   $��Bottom=�6B    J� RenderTransformOrigin$ 
0.486,0.63&�6]   $
��Left=�6�   $��46��6�   �� 5   
   -   5         ��Name$ SideATextBox��5      $��
13,0,0,-89q�6(   $
��Left=�6<   $��85��6W   $��18��6b   $��Bottom=�6n   �� 5   
   $��Side B:��6   $��0,0,150,-72q�6"   $ 0.522,1.104&�67   $��26��6[   $��Bottom=�6g   $��Right=�6�   $��46��6�   �� 5   
   -   5        $ SideBTextBox��5      $��Center=�6(   $��86��6E   $��	0,0,0,-89q�6P   $��18��6c   $��Bottom=�6o   �� 5   
   $��Side C:��6   $��
0,0,52,-71q�6"   $��26��66   $��Bottom=�6B   $��Right=�6]   $��46��6y   �� 5   
   -   5        $ SideCTextBox��5      $��Right=�6(   $��
0,0,14,-89q�6D   $��84��6X   $��18��6c   $��Bottom=�6o   �� 5   
    �� Orientation$ 
Horizontal=�6   $��
0,0,0,-133q�6.   $��Center=�6B   $	��274��6_   $��30��6k   $��Bottom=�6w   .+�5      �� -   5         ��Name$ PerimeterCheckBox��5      $��	Perimeter��62   $��5q�6F   �� 5      -   5        $ AreaCheckBox��5      $
��Area��6-   $��5q�6<   �� 5      -   5        $ MedianCheckBox��5      $��Median��6/   $��5q�6@   $y�	Collapsed=�6K   �� 5      -   5        $ BisectorCheckBox��5      $��Bisector��61   $��5q�6D   $y�	Collapsed=�6O   5      �� 5   
   -   5        	 ��Name$	 ConfirmButton��5      $��Confirm��6(   $��
0,0,0,-168q�6:   $��Center=�6j   $	��276��6�   $��19��6�   $��Bottom=�6�   �� 5   
   -	   5        $	 OKButton��5      $��OK��6#   $��
0,0,0,-199q�60   $��Center=�6[   $	��276��6x   $��19��6�   $��Bottom=�6�   5      5      