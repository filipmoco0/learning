#include <iostream>
2    using namespace std;
3    
4    int main() {
5        int n;
6        int m;
7        cout << "Odaberi studij:\n" << endl;
8        cout << "1. Informatički menadžment\n" << endl;
9        cout << "2. Menadžment ruralnog turizma\n" << endl;
10       cout << "3. Poduzetništvo\n" << endl;
11       cout << "4. Programsko inžinjerstvo\n" << endl;
12       cout << "5. Telekomunikacije i elektrotehnika\n" << endl;
13       cout << "Odabir: " << endl;
14   
15       cin >> n;
16       switch (n) {
17           case 1:
18               cout << "Informatički menadđment\n" << endl;
19               cout << "1. Godina\n" << endl;
20               cout << "2. Godina\n" << endl;
21               cout << "3. Godina\n" << endl;
22               cout << "Odabir" << endl;
23   
24               cin >> m;
25               switch (m) {
26                   case 1:
27                       cout << "I. Semestar: OE, MAT, UO, METOD, INF, PE1\n" << endl;
28                       cout << "II. Semestar: ETD, FM, TP, GROS, PE2" << endl;
29                       break;
30                   case 2:
31                       cout << "III. Semestar: OR, MEN, ICT, RP, PK, PE3\n" << endl;
32                       cout << "IV. Semestar: PS, EB, POD, MARK, PE4" << endl;
33                       break;
34                   case 3:
35                       cout << "V. Semestar: FM, PIS, BP, GEU, IS, SP\n" << endl;
36                       cout << "VI. Semestar: LJR, RM, ZAVRŠNI" << endl;
37                       break;
38               }
39               break;
40           case 2:
41               cout << "Menadžment ruralnog turizma\n" << endl;
42               cout << "1. Godina\n" << endl;
43               cout << "2. Godina\n" << endl;
44               cout << "3. Godina\n" << endl;
45               cout << "Odabir" << endl;
46   
47               cin >> m;
48               switch (m) {
49                   case 1:
50                       cout << "I. Semestar: ME, GM, METOD, PT, INF, PE1\n" << endl;
51                       cout << "II. Semestar: ETD, FM, TP, GROS, PE2" << endl;
52                       break;
53                   case 2:
54                       cout << "III. Semestar: OR, MEN, ICT, RP, PK, PE3\n" << endl;
55                       cout << "IV. Semestar: PS, EB, POD, MARK, PE4" << endl;
56                       break;
57                   case 3:
58                       cout << "V. Semestar: FM, PIS, BP, GEU, IS, SP\n" << endl;
59                       cout << "VI. Semestar: LJR, RM, ZAVRŠNI" << endl;
60                       break;
61               }
62               break;
63           case 3:
64               cout << "Poduzetništvo\n" << endl;
65               cout << "1. Godina\n" << endl;
66               cout << "2. Godina\n" << endl;
67               cout << "3. Godina\n" << endl;
68               cout << "Odabir" << endl;
69   
70               cin >> m;
71               switch (m) {
72                   case 1:
73                       cout << "I. Semestar: ME, GM, METOD, PT, INF, PE1\n" << endl;
74                       cout << "II. Semestar: ETD, FM, TP, GROS, PE2" << endl;
75                       break;
76                   case 2:
77                       cout << "III. Semestar: OR, MEN, ICT, RP, PK, PE3\n" << endl;
78                       cout << "IV. Semestar: PS, EB, POD, MARK, PE4" << endl;
79                       break;
80                   case 3:
81                       cout << "V. Semestar: FM, PIS, BP, GEU, IS, SP\n" << endl;
82                       cout << "VI. Semestar: LJR, RM, ZAVRŠNI" << endl;
83                       break;
84               }
85               break;
86           case 4:
87               cout << "Programsko inžinjerstvo\n" << endl;
88               cout << "1. Godina\n" << endl;
89               cout << "2. Godina\n" << endl;
90               cout << "3. Godina\n" << endl;
91               cout << "Odabir" << endl;
92   
93               cin >> m;
94               switch (m) {
95                   case 1:
96                       cout << "I. Semestar: ME, GM, METOD, PT, INF, PE1\n" << endl;
97                       cout << "II. Semestar: ETD, FM, TP, GROS, PE2" << endl;
98                       break;
99                   case 2:
100                      cout << "III. Semestar: OR, MEN, ICT, RP, PK, PE3\n" << endl;
101                      cout << "IV. Semestar: PS, EB, POD, MARK, PE4" << endl;
102                      break;
103                  case 3:
104                      cout << "V. Semestar: FM, PIS, BP, GEU, IS, SP\n" << endl;
105                      cout << "VI. Semestar: LJR, RM, ZAVRŠNI" << endl;
106                      break;
107              }
108              break;
109          case 5:
110              cout << "Telekomunikacije i elektrotehnika\n" << endl;
111              cout << "1. Godina\n" << endl;
112              cout << "2. Godina\n" << endl;
113              cout << "3. Godina\n" << endl;
114              cout << "Odabir" << endl;
115  
116              cin >> m;
117              switch (m) {
118                  case 1:
119                      cout << "I. Semestar: ME, GM, METOD, PT, INF, PE1\n" << endl;
120                      cout << "II. Semestar: ETD, FM, TP, GROS, PE2" << endl;
121                      break;
122                  case 2:
123                      cout << "III. Semestar: OR, MEN, ICT, RP, PK, PE3\n" << endl;
124                      cout << "IV. Semestar: PS, EB, POD, MARK, PE4" << endl;
125                      break;
126                  case 3:
127                      cout << "V. Semestar: FM, PIS, BP, GEU, IS, SP\n" << endl;
128                      cout << "VI. Semestar: LJR, RM, ZAVRŠNI" << endl;
129                      break;
130              }
131              break;
132      }
133      return 0;
134  }
