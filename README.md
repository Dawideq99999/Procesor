  PROCESOR                                                                                   
OPIS:
Symulator procesora zajmuje się wykonywaniem rozkazów MOV oraz 
XCHG dla rejestrów AX, BX, CX oraz DX.
OPIS DZIAŁANIA:
Aby rozpocząć operacje trzeba najpierw przypisać rejestry, których 
domyślna wartość jest ustalona na NULL. Można to zrobić ręcznie 
wpisując je w pola lub kliknąć przycisk „LOSUJ”, który wypełni je 
automatycznie liczbami z zakresu 0 – 9999 za nas.
W okienku dostępne jest osiem okienek tzw. „checkbox”,
podzielonych na dwie kolumny („FROM” i „TO”) po cztery okienka. 
Zaznaczając po jednym okienku z każdej kolumny możemy wykonać 
operację MOV lub XCHG na procesorze, klikając odpowiedni przycisk.
Logika jest opisana za pomocą warunków „if” wliczając wszystkie 16 
przypadków dla obu operacji. Wpisana w pole wartość automatycznie 
uzupełnia wartość rejestru. Jeśli wyczyścimy pole, wartość rejestru 
wróci do stanu początkowego NULL
