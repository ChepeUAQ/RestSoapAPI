import soap from 'soap';

export class soapService {
    private wsdlUrl: string;

    constructor(wsdlUrl: string) {
        this.wsdlUrl = wsdlUrl;
    }

    async getPiezaById(id: string): Promise<any> {
        const client = await soap.createClientAsync(this.wsdlUrl);
        return new Promise((resolve, reject) => {
            client.GetPiezaById({ id }, (err: any, result: any) => {
                if (err) return reject(err);
                resolve(result);
            });
        });
    }

    // Implementa otros métodos SOAP según sea necesario
}
