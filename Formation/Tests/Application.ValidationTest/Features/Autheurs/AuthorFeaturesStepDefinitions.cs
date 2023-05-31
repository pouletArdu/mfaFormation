using Appllication.Author;
using System;
using TechTalk.SpecFlow;

namespace Application.ValidationTest.Features.Autheurs
{
    [Binding]
    public class AuthorFeaturesStepDefinitions : Testing, IDisposable
    {
        private AddAuthorCommand _command;
        private int _addAuthorResult;
        private Exception _exception;

        public void Dispose()
        {
            AuthorRepositoryMock.Dispose();
        }


        [Given(@"Un auteur existe")]
        public void GivenUnAuteurExiste()
        {
            _command = new AddAuthorCommand();
        }

        [Given(@"son nom est (.*)")]
        public void GivenSonNomEstJohn(string name)
        {
            _command.LastName = name;
        }

        [Given(@"son prenom est (.*)")]
        public void GivenSonPrenomEstDoe(string name)
        {
            _command.FirstName = name;
        }

        [Given(@"sa date de naissance est (.*)")]
        public void GivenSaDateDeNaissanceEst(DateTime date)
        {
            _command.BirthDate = date;
        }

        [When(@"je veux ajouter un auteur")]
        public async Task WhenJeVeuxAjouterUnAuteur()
        {
            try
            {
                _addAuthorResult = await SendAsync(_command);

            }
            catch (Exception e)
            {
                _exception = e;
            }
        }

        [Then(@"l'auteur est ajouté")]
        public void ThenLauteurEstAjoute()
        {
            AuthorRepositoryMock.Authors.Should().HaveCount(1);
        }

        [Then(@"Aucune exception n'est levée")]
        public void ThenAucuneExceptionNestLevee()
        {
            _exception.Should().BeNull();
        }

        [Then(@"le resultat est (.*)")]
        public void ThenLeResultatEst(int result)
        {
            _addAuthorResult.Should().Be(result);
        }

    }
}
