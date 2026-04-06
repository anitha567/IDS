/*****************************************************************
Autor: Ana Carolina Sánchez Aragón
Fecha: 28/03/2026
Descripción: El código presente realiza el calculo de la edad de una persona para deteminar si es o no mayor de edad
*****************************************************************/

#include <iostream>
#include <string>

using namespace std;

int main() {

    int edad;
    string nombre;

    cout << "Captura tu nombre: ";
    getline(cin>> ws, nombre);

    do {
        cout << "Captura tu edad: ";
        cin >> edad;

        if (edad <= 0 || edad >= 150) {
            cout << "La edad debe estar entre 1 y 149 años" << endl;
        } 
    } while (edad <= 0 || edad >= 150);

    cout << "¡Bienvenid@, " << nombre << "! " << endl;
    if (edad >= 18) {
        cout << "Eres mayor de edad";
    }
    else {
        cout << "Eres menor de edad";
    }
    cout << endl;
    return 0;
}
