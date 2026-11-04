import { Component, signal } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterLink, RouterLinkActive} from '@angular/router';

@Component({
  selector: 'app-header',
  standalone: true,
  imports: [CommonModule, RouterLink, RouterLinkActive],
  templateUrl: './header.component.html',
  styleUrl: './header.component.scss'
})
export class HeaderComponent {
isDropdownOpen = signal<boolean>(false);

  toggleDropdown(): void {
    this.isDropdownOpen.update((prev) => !prev);
  }

  closeDropdown(): void {
    this.isDropdownOpen.set(false);
  }
}
