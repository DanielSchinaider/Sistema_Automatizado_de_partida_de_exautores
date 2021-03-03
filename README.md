# Sistema_Automatizado_de_partida_de_exautores

Exercício de simulação de sistema automatizado de partida de exaustores industriais.


Uma certa empresa madeireira possui algumas estufas de secagem para tábuas de madeira recém cortadas, uma dessas estufas possui 4 motores-ventiladores que precisam ser acionados em sequência, pois se acionados todos ao mesmo tempo a corrente elétrica consumida na rede seria muito alta e causaria danos à rede elétrica e aos componentes que ligam os motores.
Considere que para acionar um motor deve-se imprimir a frase “ACIONANDO VENTILADOR X ” onde “X” é o número do motor (1, 2, 3 ou 4) . A lógica do algoritmo com os ventiladores no primeiro sentido de giro é:

1ª parte:

Ao iniciar aciona o motor 1, passando 6 segundos verifica se o motor 2 está acionado, caso não ele liga e volta ao 6 segundos, ao passar na validação novamente ele retorna que está ligado e verifica se o motor 3 está ativo, segue desta forma até o motor 4 estiver ligado, antes de desligar os motores passam 30 segundos.

Após os 30 segundos, imprime na tela a mensagem: “INVERTENDO SENTIDO DE GIRO DAS HÉLICES” e então o processo é o seguinte:

2ª parte:

Mesmo processo da 1ª parte, o diferencial é que o programa ao final desliga todos os motores, e mata o programa.
