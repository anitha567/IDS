/*****************************************************************
Autor: Ana Carolina Sánchez Aragón
Fecha: 05/04/2026
Descripción: El código presente realiza una Suma, Resta, Multiplicación y División
*****************************************************************/
#include <iostream>
using namespace std;

int main() {
    float num1, num2;
    
    cout << "Escribe el primer número: ";
    cin >> num1;
    cout << "Escribe el segundo número: ";
    cin >> num2;
    
    float suma = num1 + num2;
    float resta = num1 - num2;
    float multiplicacion = num1 * num2;
    float division = num1 / num2;
    
    cout << "La suma es: " << suma <<endl;
    cout << "La resta es: " << resta <<endl;
    cout << "La multiplicación es: " << multiplicacion <<endl;
    cout << "La división es: " << division <<endl;
    return 0;
}
