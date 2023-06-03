/* tslint:disable */
/* eslint-disable */
/**
 * Orders.Api, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 1.0
 * 
 *
 * NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
 * https://openapi-generator.tech
 * Do not edit the class manually.
 */

import { exists, mapValues } from '../runtime';
/**
 * 
 * @export
 * @interface OrderItem
 */
export interface OrderItem {
    /**
     * 
     * @type {number}
     * @memberof OrderItem
     */
    id?: number;
    /**
     * 
     * @type {number}
     * @memberof OrderItem
     */
    orderId?: number;
    /**
     * 
     * @type {number}
     * @memberof OrderItem
     */
    productId?: number;
    /**
     * 
     * @type {number}
     * @memberof OrderItem
     */
    count?: number;
}

/**
 * Check if a given object implements the OrderItem interface.
 */
export function instanceOfOrderItem(value: object): boolean {
    let isInstance = true;

    return isInstance;
}

export function OrderItemFromJSON(json: any): OrderItem {
    return OrderItemFromJSONTyped(json, false);
}

export function OrderItemFromJSONTyped(json: any, ignoreDiscriminator: boolean): OrderItem {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'id': !exists(json, 'id') ? undefined : json['id'],
        'orderId': !exists(json, 'orderId') ? undefined : json['orderId'],
        'productId': !exists(json, 'productId') ? undefined : json['productId'],
        'count': !exists(json, 'count') ? undefined : json['count'],
    };
}

export function OrderItemToJSON(value?: OrderItem | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'id': value.id,
        'orderId': value.orderId,
        'productId': value.productId,
        'count': value.count,
    };
}
