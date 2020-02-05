///// Watch out for unnecessary white space in the code. And the using statements should be within the namespace.
///// We wouldn't create a separate project for Interfaces, we would create an Interfaces folder in the BusinessLayer project.

using System.Collections.Generic;
using Rabobank.Training.ClassLibrary.DomainEntities;
using Rabobank.Training.ViewModels.Entities;

namespace Rabobank.Training.Business.Interfaces
{
    /// <summary>
    /// Interface exposes set of functions used for processing of file and data massaging for View Model classes.
    /// </summary>
    public interface IFundsProcessor
    {
        List<FundOfMandates> ReadFundOfMandatesFile(string fileName);
        PortfolioVM GetPortfolio();
        PositionVM GetCalculatedMandates(PositionVM position, FundOfMandates fundOfmandates);
    }
}
