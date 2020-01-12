#include <SwitchControlLibrary.h>

void setup(){

}

void loop() {
    SwitchControlLibrary().PressButtonZL();
  SwitchControlLibrary().PressButtonZR();
  delay(500);
  SwitchControlLibrary().ReleaseButtonZL();
  SwitchControlLibrary().ReleaseButtonZR();
  delay(500);
}
