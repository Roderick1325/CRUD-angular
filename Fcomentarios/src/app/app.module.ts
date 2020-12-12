import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { AgregarEditarComentarioComponent } from './components/agregar-editar-comentario/agregar-editar-comentario.component';
import { NavbarComponent } from './components/navbar/navbar.component';
import { ListComentariosComponent } from './components/list-comentarios/list-comentarios.component';

@NgModule({
  declarations: [
    AppComponent,
    AgregarEditarComentarioComponent,
    NavbarComponent,
    ListComentariosComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
