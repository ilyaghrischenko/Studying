from MVT.app import GuessNumberApp
from MVT.model import GuessNumberModel
from MVT.template import GuessNumberTemplate
from MVT.view import GuessNumberView

if __name__ == '__main__':
    template = GuessNumberTemplate()

    app = GuessNumberApp(GuessNumberView(template), template)
    app.run()