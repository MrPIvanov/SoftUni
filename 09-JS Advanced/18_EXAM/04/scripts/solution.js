function solve() {
   let rebuildKingdoms = [];
   let atacksHero = {
      mage: 70,
      fighter: 50,
      tank: 20
   };

   let defencedHero = {
      mage: 30,
      fighter: 50,
      tank: 80
   };


   let validNames = ['CASTLE', 'DUNGEON', 'FORTRESS', 'INFERNO', 'NECROPOLIS', 'RAMPART', 'STRONGHOLD', 'TOWER', 'CONFLUX'];


   let $buildBtn = $($('button')[0]);
   let $joinBtn = $($('button')[1]);
   let $warBtn = $($('button')[2]);

   $buildBtn.on('click', build);
   $joinBtn.on('click', join);
   $warBtn.on('click', war);

   function build() {
      let $kingdom = $($('#kingdom input')[0]);
      let $king = $($('#kingdom input')[1]);

      let validKing = (typeof $king.val() === 'string' || $king.val() instanceof String) && $king.val().length >= 2;
      let validKingdom = validNames.includes($kingdom.val().toUpperCase());

      if (validKing && validKingdom) {
         let $main = $(`#${$kingdom.val().toLowerCase()}`);

         let $h1 = $(`<h1>${$kingdom.val().toUpperCase()}</h1>`);

         let $div = $('<div>');
         $div.addClass('castle');

         let $h2 = $(`<h2>${$king.val().toUpperCase()}</h2>`);

         let $field = $('<fieldset>');

         let $legend = $(`<legend>Army</legend>`);
         let $p1 = $('<p>TANKS - 0</p>');
         let $p2 = $('<p>FIGHTERS - 0</p>');
         let $p3 = $('<p>MAGES - 0</p>');
         let $lastDiv = $('<div>');
         $lastDiv.addClass('armyOutput');

         $field.append($legend);
         $field.append($p1);
         $field.append($p2);
         $field.append($p3);
         $field.append($lastDiv);

         $main.append($h1);
         $main.append($div);
         $main.append($h2);
         $main.append($field);

         $main.css('display', 'block');

         let current = {
            name: $kingdom.val().toUpperCase(),
            atack: 0,
            defence: 0
         }

         rebuildKingdoms.push(current);
      } else {
         let $kingdom = $($('#kingdom input')[0]).val('');
         let $king = $($('#kingdom input')[1]).val('');
      }
   }

   function join() {
      let hero = $('input[type = radio]:checked').val();
      let charName = $($('#characters input')[3]).val();
      let kingdomName = $($('#characters input')[4]).val();

      let validcharName = (typeof charName === 'string' || charName instanceof String) && charName.length >= 2;
      let validKingdom = rebuildKingdoms.filter(x => {
         return x.name === kingdomName.toUpperCase();
      }).length > 0;

      if (hero !== undefined && validcharName && validKingdom) {
         let heroIndex = 0;
         if (hero === 'mage') {
            heroIndex = 2;
         }
         if (hero === 'fighter') {
            heroIndex = 1;
         }

         let $CurrentCastle = $(`#${kingdomName.toLowerCase()}`);

         let currentLegend = $($CurrentCastle.find('fieldset').children()[heroIndex + 1]);

         curentAmount = currentLegend.text().split(' - ')[1];
         let newAmount = '' + (+curentAmount + 1);

         currentLegend.text(currentLegend.text().replace(curentAmount, newAmount));

         let CurrentKingdonFromArray = rebuildKingdoms.filter(x => {
            return x.name === kingdomName.toUpperCase();
         })[0];


         CurrentKingdonFromArray.atack += atacksHero[hero];
         CurrentKingdonFromArray.defence += defencedHero[hero];



         let lastInfo = $($CurrentCastle.find('fieldset').find('div'));

         lastInfo.text(lastInfo.text() + `${charName} `); // Maybe Space
      } else {
         $('input[type = radio]:checked').val('');
         $($('#characters input')[3]).val('');
         $($('#characters input')[4]).val('');
      }
   }

   function war() {
      let $atacker = $($('#actions input')[0]);
      let $defender = $($('#actions input')[1]);

      let validAtacker = rebuildKingdoms.filter(x => {
         return x.name === $atacker.val().toUpperCase();
      }).length > 0;

      let validDefender = rebuildKingdoms.filter(x => {
         return x.name === $defender.val().toUpperCase();
      }).length > 0;

      if (validAtacker && validDefender) {

         let totalAtackPoint = rebuildKingdoms.filter(x => {
            return x.name === $atacker.val().toUpperCase();
         })[0].atack;

         let totalDefencePoint = rebuildKingdoms.filter(x => {
            return x.name === $defender.val().toUpperCase();
         })[0].defence;

         if (totalAtackPoint > totalDefencePoint) {
            let $losingCastle = $(`#${$defender.val().toLowerCase()}`).find('h2');


            let winnerName = $(`#${$atacker.val().toLowerCase()}`).find('h2').text();

            $losingCastle.text(winnerName);
         }
      }
      else{
         $($('#actions input')[0]).val('');
         $($('#actions input')[1]).val('');
      }
   }
}

solve();