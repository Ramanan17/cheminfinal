import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import {Routes,RouterModule} from '@angular/router'
import { AppComponent } from './app.component';
import { DatatablesComponent } from './components/datatables/datatables.component';
import { HttpModule } from '@angular/http';

const appRoutes: Routes = [
    {
         path: 'data',
        component: DatatablesComponent
    }
    
];
@NgModule({
  declarations: [
    AppComponent,
    DatatablesComponent
  ],
  imports: [
      BrowserModule,
      
      HttpModule,
      RouterModule.forRoot(
          appRoutes,
           // <-- debugging purposes only
      )
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
