/*****************************************************************
Autor: Ana Carolina Sánchez Aragón
Fecha: 05/04/2026
Descripción: El código presente realiza una asignación de RFC
*****************************************************************/
#include <iostream>
#include <string>
#include <algorithm>
using namespace std;

class generadorRFC{
    private:
        string nombre;
        string apellidoPaterno;
        string apellidoMaterno;
        string dia, mes, anio;
        
        void limpiarTexto(string &texto){
            string conAcento[] = {"á", "é", "í", "ó", "ú", "ñ", "Á", "É", "Í", "Ó", "Ú", "Ñ"};
            string sinAcento[] = {"a", "e", "i", "o", "u", "x", "A", "E", "I", "O", "U", "X"};
            
            for (int i = 0; i < 12; i++){
                size_t posicion = texto.find(conAcento[i]);
                while (posicion != string::npos){
                    texto.replace(posicion, conAcento[i].length(), sinAcento[i]);
                    posicion = texto.find(conAcento[i]);
                }
            }
        }
        
        void sanitizarRFC(string &rfc) {
            string letras = rfc.substr (0,4);
            const string palabrasProhibidas[] = {"BUEI", "BUEY", "CACA", "CACO", "CAGA", "CAGO", "CAKA", "CAKO", "COGE", "COGI", "COJA", "COJE", "COJI", "COJO", "COLA", "CULO", "FALO", "FETO", "GETA", "GUEI", "GUEY", "JETA", "JOTO", "KACA", "KACO", "KAGA", "KAGO", "KAKA", "KAKO", "KOGE", "KOGI", "KOJA", "KOJE", "KOJI", "KOJO", "KOLA", "KULO", "LILO", "LOCA", "LOCO", "LOKA", "LOKO", "MAME", "MAMO", "MEAR", "MEAS", "MEON", "MIAR", "MION", "MOCO", "MOKO", "MULA", "PEDA", "PEDO", "PENE", "PUTA", "PUTO", "QULO", "RATA", "ROBA", "ROBE", "ROBO", "RUIN", "SENO", "TETA", "VACA", "VAGA", "VAGO", "VUEI", "VUEY", "WUEI", "WUEY"};
            
            for (const string& palabra : palabrasProhibidas){
                if (letras == palabra){
                    rfc[3] = 'X';
                    cout << "Tu RFC fué sanitizado por seguridad." << endl;
                    break;
                }
            }
        }
        
    public:
        void capturarDatos(){
            cout << "Calculo de RFC" << endl;
            cout << "===============" << endl;
            cout << "Introduce tu nombre: ";
            getline(cin,nombre);
            cout << "Introduce tu apellido paterno: ";
            getline(cin,apellidoPaterno);
            cout << "Introduce tu apellido materno: ";
            getline(cin,apellidoMaterno);
            cout << "Introduce tu fecha de nacimiento con solo números: " << endl;
            cout << "Día: ";
            cin >> dia;
            cout << "Mes: ";
            cin >> mes;
            cout << "Año: ";
            cin >> anio;
            
            limpiarTexto(nombre);
            limpiarTexto(apellidoPaterno);
            limpiarTexto(apellidoMaterno);
        }

        void mostrarRFC(){
            string rfc = "";
        
            rfc += apellidoPaterno[0];
            
            for (size_t i = 1; i < apellidoPaterno.length(); i++){
                char vocal = toupper(apellidoPaterno[i]);
                if (vocal == 'A' || vocal == 'E' || vocal == 'I' || vocal == 'O'|| vocal == 'U'){
                    rfc += apellidoPaterno.substr(i,1);
                    break;
                }
            }
        
        if (apellidoMaterno.empty() || apellidoMaterno == " "){
            rfc += "X";
        } else{
            rfc += apellidoMaterno.substr(0,1);
        }
        
        rfc += nombre.substr(0,1);
        
        rfc += anio.substr(anio.length() -2);
        
        string mesStr = "0" + mes;
        rfc += mesStr.substr(mesStr.length() -2);
        
        string diaStr = "0" + dia;
        rfc += diaStr.substr(diaStr.length() -2);
        
        for (auto & letra : rfc) letra = toupper(letra);
        
        sanitizarRFC(rfc);
        
        cout << "Tu RFC sin homoclave es: " << rfc << endl;
        
    }
};

int main(){
    generadorRFC empleado;
    
    empleado.capturarDatos();
    empleado.mostrarRFC();
    
    return 0;
    
}
