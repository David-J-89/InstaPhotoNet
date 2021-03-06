import { Routes } from '@angular/router';
import { HomeComponent } from './home/home.component';
import { UserListComponent } from './users/user-list/user-list.component';
import { MessagesComponent } from './messages/messages.component';
import { ListsComponent } from './lists/lists.component';
import { AuthGuard } from './_guards/auth.guard';
import { UserDetailComponent } from './users/user-detail/user-detail.component';
import { UserDetailResolver } from './_resolvers/user-detail.resolver';
import { UserListResolver } from './_resolvers/user-list.resolver';
import { UserEditComponent } from './users/user-edit/user-edit.component';
import { UserEditResolver } from './_resolvers/user-edit.resolver';
import { PreventUnsavedChanges } from './_guards/prevent-unsaved-changes.guard';
import { PhotoListComponent } from './users/photo-list/photo-list.component';

export const appRoutes: Routes = [
  { path: '', component: HomeComponent },
  {
    path: '', // localhost:4200/users
    runGuardsAndResolvers: 'always',
    canActivate: [AuthGuard],
    children: [
      {
        path: 'users', component: UserListComponent,
        resolve: { users: UserListResolver }
      },
      {
        path: 'users/:id', component: UserDetailComponent,
        resolve: { user: UserDetailResolver }
      },
      {
        path: 'user/edit', component: UserEditComponent,
        resolve: { user: UserEditResolver }, canDeactivate: [PreventUnsavedChanges]
      },
      { path: 'messages', component: MessagesComponent },
      { path: 'lists', component: ListsComponent },
      { path: 'posts', component: PhotoListComponent }
    ]
  },
  { path: '**', redirectTo: '', pathMatch: 'full' },

];

