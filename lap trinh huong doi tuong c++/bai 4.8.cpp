#include <iostream>
class NV {
    private:
    int ma;
    char hoten[30];
    float hsl;
    public:
    NV(int m, char t[], float hs) {
        ma = m;
        strcpy(hoten, t);
        hsl = hs;
    }
};
class NVKD : public NV {
    float dt;
    public: 
    NVKD(int m, char t[], float hs, float d) : NV(m, t, hs) {
        dt = d;
    }
    double luong() {
        return hsl* (0.02*dt);
    }
    void show() {
        
    }
}