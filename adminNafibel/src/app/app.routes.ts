import { Routes } from '@angular/router';
import { DashboardComponent } from './components/dashboard/dashboard.component';
import { HairDressersComponent } from './components/hair-dressers/hair-dressers.component';
import { HairStylesComponent } from './components/hair-styles/hair-styles.component';
import { ClientsComponent } from './components/clients/clients.component';
import { AppointmentsComponent } from './components/appointments/appointments.component';
import {DetailHairstyleComponent} from './components/detail-hairstyle/detail-hairstyle.component';
import {HairtyleListComponent} from './components/hairtyle-list/hairtyle-list.component';

export const routes: Routes = [
  { path: 'hairdresser', component: HairDressersComponent },
  { path: 'hairstyle', component: HairStylesComponent },
  { path: 'client', component: ClientsComponent },
  { path: 'detail-hairstyle', component: DetailHairstyleComponent },
  { path: 'appointment', component: AppointmentsComponent },
  { path: 'hairtyle-list',component: HairtyleListComponent },
  { path: '', component: DashboardComponent, pathMatch: 'full' },
  { path: '**', redirectTo: '', pathMatch: 'full' }  // Redirection pour les routes incorrectes
];
