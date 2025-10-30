#include <iostream>
using namespace std;

int main() {
    int br = 0;
    for (int i = 10; i <= 10000; i++) {
        if (i % 100 == 0 && i >= 8000) {
            cout << i << endl;
            br++;
        }
    }
    cout << "There are " << br << " numbers." << endl;
}
