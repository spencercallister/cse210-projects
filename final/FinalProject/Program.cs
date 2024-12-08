using System;

class Program
{
    static async Task Main(string[] args)
    {
        ContractorRequest contractor = new();
        await contractor.GetPlace();
    }
}