   M S B A M L   `   `   `  ����L  HCourseScheduleWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:CourseScheduleWPFCourseScheduleWPF  5   	   "    CourseScheduleWPF.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:CourseScheduleWPF     5   	     � Title$)  #Course Schedule v2 - Joseph Salinas��5   	   $��688.973��65   $��1117.098��6F   .��5	      � .+�5
   
   �� -   5         ��Name$ label��5
      $��Course Filename��6   $
��Left=�69   $��6,10,0,0q�6T   $	��Top=�6f   �� 5   
   -   5         ��Name$ textBoxCourseFileName��5      $��108,14,10,0q�61    �� TextWrapping$
 Wrap=�6F   $	��Top=�6Z    J� RenderTransformOrigin$ 0.503,0.895&�6r   $��23��6�   �� 5   
   -   5         ��Name$ OpenCoursebutton��5      $��Open Course Collection
��6+   $
��Left=�6V   $��	10,41,0,0q�6q   $	��Top=�6�   $	��187��6�   $��30��6�   $��Center=�6�   �� 5   
   -   5         ��Name$ groupBox��5      $��Find Course��6%   $
��Left=�6:   $��	10,88,0,0q�6U   $	��Top=�6h   $	��270��6�   $	��214��6�   .��5      � $
��Left=�6   $	��251��6.   $	��Top=�6;   $	��204��6S   $��	0,0,-2,-4q�6_   .+�5      �� -   5        $ label1��5      $��	Course Id��6(   $
��Left=�6<   $��0,10,0,0q�6W   $	��Top=�6i   �� 5      -   5        $ textBoxFindCourseId��5      $��23��67   $��	68,13,5,0q�6C   $
 Wrap=�6V   $	��Top=�6j   $��0q�6�   �� 5      -   5        $ FindCourseIdbutton��5      $��Find by Course Id��65   $
��Left=�6Q   $��
10,51,10,0q�6l   $	��Top=�6�   $	��184��6�   $��32��6�   6�   �� 5      -   5        $ label2��5      $��
Designator��6(   $
��Left=�6=   $��0,99,0,0q�6X   $	��Top=�6j   �� 5      -	   5        $ label3��5      $��Number��6(   $
��Left=�69   $��	0,130,0,0q�6T   $	��Top=�6g   �� 5      -
   5        $ textBoxFindDesignator��5      $��23��69   $��
68,102,5,0q�6E   $
 Wrap=�6Y   $	��Top=�6m   $��0q�6�   �� 5      -   5        $ textBoxFindNumber��5      $��23��65   $��
68,133,5,0q�6A   $
 Wrap=�6U   $	��Top=�6i   $��0q�6�   �� 5      -   5        $ FindDesNumbutton��5      $#��Find by Designator and Number��63   $
��Left=�6[   $��	5,173,0,0q�6v   $	��Top=�6�   $	��194��6�   $��32��6�   6�   5      5      �� 5   
   -   5        $ 	groupBox1��5      $��Course Data��6&   $��240,88,10,0q�6;   $	��Top=�6P   $	��270��6h   � 5   
   $	��251��6   $��240,107,10,0q�6   $	��Top=�62   .+�5      �� -   5        $ label4��5      $��Course Id
��6$   $
��Left=�6B   $��	10,19,0,0q�6]   $	��Top=�6p   �� 5      -   5        $ label5��5      $��
Designator��6$   $
��Left=�69   $��	10,50,0,0q�6T   $	��Top=�6g   �� 5      -   5        $ label6��5      $��Number��6$   $
��Left=�65   $��	10,81,0,0q�6P   $	��Top=�6c   �� 5      -   5        $ label7��5      $��Title��6$   $
��Left=�64   $��
10,112,0,0q�6O   $	��Top=�6c   �� 5      -   5        $ label8��5      $��Credits��6$   $
��Left=�66   $��
10,143,0,0q�6Q   $	��Top=�6e   �� 5       -   5        $ label9��5       $��Description��6$   $
��Left=�6:   $��
10,174,0,0q�6U   $	��Top=�6i   �� 5!      -   5        $ textBoxCourseIdData��5!      $��23��63   $��
88,23,10,0q�6?   $
 Wrap=�6S   $	��Top=�6g   �� 5"      -   5        $ textBoxDesignatorData��5"      $��23��65   $��
88,53,10,0q�6A   $
 Wrap=�6U   $	��Top=�6i   �� 5#      -   5        $ textBoxNumberData��5#      $��23��61   $��
88,81,10,0q�6=   $
 Wrap=�6Q   $	��Top=�6e   �� 5$      -   5        $ textBoxTitleData��5$      $��23��60   $��88,112,10,0q�6<   $
 Wrap=�6Q   $	��Top=�6e   �� 5%      -   5        $ textBoxCreditsData��5%      $��23��62   $��88,143,10,0q�6>   $
 Wrap=�6S   $	��Top=�6g   �� 5&      -   5        $ textBoxDescriptionData��5&      $��88,174,10,0q�66   $
 Wrap=�6K   $	��Top=�6_   $��67��6w   5'      �� 5(   
   -   5        $ 	groupBox2��5(      $��Professor Data��6&   $��10,363,10,9.5q�6>   .��5)      � $��0,10,-2,-13q�6   .+�5*      �� -   5        $ label10��5*      $��Professors Filename��6)   $
��Left=�6G   $��10,0,0,0q�6b   $	��Top=�6t   �� 5+      -   5        $ textBoxProfessorFileName��5+      $��
130,4,16,0q�6<   $
 Wrap=�6P   $	��Top=�6d   $��22��6|   �� 5,      -   5        $ OpenProfbutton��5,      $��Open Professor Collection��61   $
��Left=�6U   $��	10,31,0,0q�6p   $	��Top=�6�   $	��152��6�   $��35��6�   6�   �� 5-      -   5         ��Name$! listViewProfessorCollection��5-      $��10,71,10,20q�6@    �� View 5.      �� 5/      .P�50      �� $��Id��6S   	 �� DisplayMemberBinding	 6-   �� *n_ID+6S   �� 51      $
��Name��6U   	 6-   �� *n_Name+6U   �� 52      $��Phone��6V   	 6-   �� *	n_Phone+6V   53      55      56      57      59      5:      