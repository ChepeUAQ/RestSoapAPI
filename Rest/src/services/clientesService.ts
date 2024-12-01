import { ClientesRepository } from '../repositories/clientesRepository';
import { CorreoExistente } from '../exceptions/correoExistente'; 
import { PiezaInvalida } from '../exceptions/piezaInvalida';
import { Pieza } from '../models/piezasModel';

import { soapService } from './soapService';


export class ClientesService {
  private soapService: soapService;
  private clientesRepository: ClientesRepository; 

  constructor(soapService: soapService, clientesRepository: ClientesRepository) {
    this.soapService = soapService;
    this.clientesRepository = clientesRepository;
  }

    async getClienteById(id: string) {
        const Key = `cliente:${id}`;
    
        const cliente = await this.clientesRepository.getClienteById(id);
    
        if (cliente) {
            const productos = await Promise.all(
                cliente.productosComprados.map(async (productoId: string) => {
                    const producto = await this.soapService.getPiezaById(productoId);
                    return producto ? producto : { mensaje: "Producto no encontrado" }; 
                })
            );
    
            const clienteConProductos = { ...cliente, productos }; 
    
            return clienteConProductos;
        }
    
        return null; 
    }
    

    async deleteClienteById(id: string) {
        return this.clientesRepository.deleteClienteById(id);
    }

    async createCliente(nombre: string, correo: string, telefono: string, productosComprados: string[]) {
       
        const existeCorreo = await this.clientesRepository.existsByCorreo(correo);
        if (existeCorreo) {
            throw new CorreoExistente("El correo que intentas dar de alta ya existe"); 
        }
    
        for (const productoId of productosComprados) {
            const producto = await Pieza.findById(productoId);
            if (!producto) {
                throw new PiezaInvalida(`El producto con ID ${productoId} no existe.`);
            }
        }
    
       
        return this.clientesRepository.createCliente(nombre, correo, telefono, productosComprados);
    }
    

    async updateCliente(id: string, nombre: string, correo: string, telefono: string, productosComprados: string[]) {
        const existe = await this.clientesRepository.existsByCorreo(correo);
        if (existe) {
            throw new CorreoExistente("El correo que intentas dar de alta ya existe");
        }

        for (const productoId of productosComprados) {
            const producto = await Pieza.findById(productoId);
            if (!producto) {
                throw new PiezaInvalida(`El producto con ID ${productoId} no existe.`);
            }
        }

        return this.clientesRepository.updateCliente(id, nombre, correo, telefono, productosComprados);
    }
    

    async updatePatchCliente(id: string, nombre: string, correo: string, telefono: string, productosComprados: string[]) {
        const existe = await this.clientesRepository.existsByCorreo(correo);
        if (existe) {
            throw new CorreoExistente("El correo que intentas dar de alta ya existe");
        }
        for (const productoId of productosComprados) {
            const producto = await Pieza.findById(productoId);
            if (!producto) {
                throw new PiezaInvalida(`El producto con ID ${productoId} no existe.`);
            }
        }
        return this.clientesRepository.updatePatchCliente(id, nombre, correo, telefono, productosComprados);
    }
}
