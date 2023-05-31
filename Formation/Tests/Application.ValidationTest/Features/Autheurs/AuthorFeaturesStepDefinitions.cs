using System;
using TechTalk.SpecFlow;

namespace Application.ValidationTest.Features.Autheurs
{
    [Binding]
    public class AuthorFeaturesStepDefinitions
    {
        [Given(@"Un auteur existe")]
        public void GivenUnAuteurExiste()
        {
            throw new PendingStepException();
        }

        [Given(@"son nom est (.*)")]
        public void GivenSonNomEstJohn(string name)
        {
            throw new PendingStepException();
        }

        [Given(@"son prenom est (.*)")]
        public void GivenSonPrenomEstDoe(string name)
        {
            throw new PendingStepException();
        }

        [When(@"je veux ajouter un auteur")]
        public void WhenJeVeuxAjouterUnAuteur()
        {
            throw new PendingStepException();
        }

        [Then(@"l'auteur est ajouté")]
        public void ThenLauteurEstAjoute()
        {
            throw new PendingStepException();
        }

        [Given(@"sa date de naissance est (.*)")]
        public void GivenSaDateDeNaissanceEst(DateTime date)
        {
            throw new PendingStepException();
        }

    }
}
