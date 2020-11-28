import { Owner } from './owner.model';

export interface Computer {
    computerId: number;
    cpu: string;
    ram: string;
    gpu: string;
    case: string;
    psu: string;
    motherboard: string;
    os: string;
    ownerId: number;
    owner: Owner;
}