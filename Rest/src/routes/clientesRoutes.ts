import { Router } from 'express';
import { ClientesController } from '../controllers/clientesController';
import { soapService } from '../services/soapService';

const router = Router();

const wsdlUrl = 'http://piezas-api-svc:8080/PiezaService.svc?wsdl';

console.log('WSDL URL:', wsdlUrl);

if(wsdlUrl === undefined) {
    throw new Error('WSDL URL not found');
}else{
    console.log('WSDL URL found');
}

const piezasService = new soapService(wsdlUrl);
const clientesController = new ClientesController(piezasService);

router.get('/clientes/:id', clientesController.getClienteById.bind(clientesController));
router.delete('/clientes/delete/:id', clientesController.deleteClienteById.bind(clientesController));
router.post('/clientes', clientesController.createCliente.bind(clientesController));
router.put('/clientes/update/:id', clientesController.updateCliente.bind(clientesController));
router.patch('/clientes/updatePatch/:id', clientesController.updatePatchCliente.bind(clientesController));

export default router;
