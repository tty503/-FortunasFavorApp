import { Entity, PrimaryGeneratedColumn, Column } from "typeorm";

@Entity()
export class Debt
{
    @PrimaryGeneratedColumn
    Id: String;             // Guid : debe crearse una funcion para generar GUID en caso de : https://www.squash.io/tutorial-generating-guid-in-typescript/

    @Column
    Description: String;

    @Column
    Amount: Number;

    @Column
    InterestRate: Number;

    @Column
    StartDate: Date;

    @Column
    DueDate: Date;

    @Column
    MinimumPayment: Number;

    @Column
    PaymentSchedule: Date;

    @Column
    Status: Boolean;

    // UserId, AccountId
}