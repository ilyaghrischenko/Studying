from Country import Country
from City import City
from Human import Human

ukraine = Country('Ukraine',
                  'Europe',
                  38000000,
                  '+380',
                  'Kyiv',
                  ['Potava', 'Kremenchuk', 'Odessa'])
kremenchuk = City('Kremenchuk',
                  'Poltava region',
                  ukraine,
                  215000,
                  '39600',
                  '+380')
illia = Human('Hryshchenko Illia Vladimirovich',
              '12.04.2005',
              '+380970878346',
              kremenchuk,
              ukraine,
              'Nebesnoi Sotni 51')

illia.print()
