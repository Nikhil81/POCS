   M S B A M L   `   `   `  ����D  @training1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:training1	training1  5   	       training1.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:training1     5   	     � Title$  
MainWindow��5   	   $	��350��6   $	��525��6)   .��5	      �� -   5         ��Name$ txtAddr��5	      .+�5
   
   �� -   5         ��Name$ 	lablename��5
      $
��Name��6#    �� Left$ 30��62   
 �� Top$ 53��6C   �� 5   
   -   5        $ label1��5      $��Id��6    $ 30��6-   $ 96��6>   �� 5   
   -   5        $ label2��5      $��Salary��6    $ 30��61   $	 135��6B    J� RenderTransformOrigin$ -0.309,-0.7&�6S   �� 5   
   -   5         ��Name$ textBox��5      $��23��6#   $	 129��6E    �� TextWrapping$
 Wrap=�6W   $ 55��6l   $	��120��6|   ��6/   �� *Name+6|   �� 5   
   -   5        $ textBox1��5      $��23��6$   $	 129��60   $
 Wrap=�6B   $ 99��6m   $	��120��6}   ��6V   �� *EmpId+6}   �� 5   
   -   5        $ textBox2��5      $��23��6$   $	 129��60   $
 Wrap=�6B   $	 138��6n   $	��120��6   ��6V   �� *Salary+6   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ empGrid��5      $ 30��6$   $	 166��65   $	��106��6F   $	��450��6S   �� 5   
   -	   5        $ NewName��5      $��New Name��6!   $	 289��64   $ 53��6F   �� 5   
   -
   5        $ 
txtNewName��5      $��23��6&   $	 398��62   $
 Wrap=�6D   $�� ��6X   $ 55��6`   $	��120��6p   6|   �� 5   
   -   5        	 ��Name$	 btnAdd��5      $	��Add��6!   $ 30��6/   $	 292��6@   $��75��6Q   6\   �� 5   
   -   5        $	 	btnRemove��5      $��Remove��6$   $	 155��65   $	 292��6G   $��75��6X   6c   54      55      