import { OrderItem } from './order-item';

export interface Order {
  id: number;
  subtotal: number;
  items?: OrderItem[];
}
