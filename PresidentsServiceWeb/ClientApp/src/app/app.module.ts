import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';

import { AppComponent } from './app.component';
import { PresidentsComponent } from './presidents/presidents.component';
import { PresidentsService } from './presidents/presidents.service';

@NgModule({
  declarations: [
    AppComponent,
    PresidentsComponent
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule
  ],
  providers: [PresidentsService],
  bootstrap: [AppComponent]
})
export class AppModule { }
