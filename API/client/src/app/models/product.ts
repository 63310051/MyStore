export interface Product {
    id: number
    prod_name: string
    prod_desc: string
    price: number
    prod_pics: string
    prod_type?: string
    brand: string
    quantityInStock?: number
}
// ? = optional