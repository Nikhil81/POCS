   M S B A M L   `   `   `  ����L  HConvertersExample, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:ConvertersExampleConvertersExample  5   	   "    ConvertersExample.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:ConvertersExample     5   	     � Title$  
MainWindow��5   	   $	��350��6   $	��525��6)   .��5	      ��  � 	Resources 5
   
   ,   &ConvertersExample.WordToColorConverter   
word2Color��%   &	          5      6>   5      .+�5   
   �� -   5         ��Name$ txtColor��5   +   $	��100��6   $	��200��6   6?   �� 5   
   -   5         ��Name$ rect1��5   !   $	��150��6   $	��150��60   ��6<   ��  �� ElementName$ txtColor�� �� Path$
 Text� �� 	Converter# [   �� Mode$ OneWayToSource=�6�   �� 5   
   -   5        $
��btn1��5      $��change to red��6   $	��100��65   $	��100��6B   6c   5      5      