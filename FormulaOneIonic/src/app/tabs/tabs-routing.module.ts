import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { TabsPage } from './tabs.page';

const routes: Routes = [
  {
    path: 'tabs',
    component: TabsPage,
    children: [
      {
        path: 'teams',
        children: [
          {
            path: '',
            loadChildren: () => import('../teams/teams.module').then(m => m.TeamsPageModule)
          }
        ]
      },
      {
        path: 'drivers',
        children: [
          {
            path: '',
            loadChildren: () => import('../drivers/drivers.module').then(m => m.DriversPageModule)
          }
        ]
      },
      {
        path: 'circuits',
        children: [
          {
            path: '',
            loadChildren: () => import('../circuits/circuits.module').then(m => m.CircuitsPageModule)
          }
        ]
      },
      {
        path: '',
        redirectTo: 'teams',
        pathMatch: 'full'
      }
    ]
  },
  {
    path: '',
    redirectTo: '/tabs/teams',
    pathMatch: 'full'
  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class TabsPageRoutingModule { }
