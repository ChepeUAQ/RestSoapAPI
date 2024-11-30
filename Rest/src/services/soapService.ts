import * as soap from 'soap';

export class soapService {
    private wsdlUrl: string;

    constructor(wsdlUrl: string) {
        this.wsdlUrl = wsdlUrl;
    }

    async getPiezaById(id: string): Promise<any> {
        try {
            console.log(`Solicitando pieza con ID: ${id}`);
            
        
            const soapClient = await soap.createClientAsync(this.wsdlUrl);
            console.log('Cliente SOAP creado exitosamente');
            
           
            const [result, rawResponse, soapHeader] = await soapClient.GetPiezaByIdAsync({ id });
            console.log('Resultado completo SOAP:', result);
            console.log('Respuesta cruda SOAP:', rawResponse);
            console.log('Cabecera SOAP:', soapHeader);
            
            
            if (!result || !result.GetPiezaByIdResult) {
                console.error('La respuesta no contiene los datos esperados.');
                throw new Error('La respuesta SOAP no contiene datos esperados.');
            }

            console.log('Pieza obtenida:', result.GetPiezaByIdResult);

            return result.GetPiezaByIdResult;

        } catch (error) {
            console.error('Error al realizar la solicitud SOAP:', error);

           
            if ((error as any).response) {
                const errorResponse = error as { response?: any };
                console.error('Respuesta SOAP de error:', errorResponse.response);
            }

    
            if (error instanceof Error) {
               
                console.error('Mensaje de error:', error.message);
                throw new Error(`No se pudo obtener la pieza. Detalles: ${error.message}`);
            } else {
               
                console.error('Error desconocido:', String(error));
                throw new Error(`No se pudo obtener la pieza. Detalles: ${String(error)}`);
            }
        }
    }
}
