using CursoCSharp;

//ArrayExemplos.DemonstrarArray();
//ListaExemplo.DemonstrarLista();
//EscopoVariaveis escopo = new EscopoVariaveis();

/* Aluno arthur = new Aluno();
arthur.Nome = "Arthur Braga";
arthur.Matricula = "6464646464723";
arthur.Curso = "Tecnico";

Aluno Suelen = new Aluno();
Suelen.Nome = "Suelen";
Suelen.Matricula = "215144857423";
Suelen.Curso = "Tecnico";

Console.WriteLine($"Nome: {arthur.Nome}, Matrícula: {arthur.Matricula}, Curso: {arthur.Curso}");

Console.WriteLine($"Nome: {Suelen.Nome}, Matrícula: {Suelen.Matricula}, Curso: {Suelen.Curso}"); */

/* TratarExcecoes tr = new TratarExcecoes();
tr.ExecutarDivisao(9,3);
TratarExcecoes tr1 = new TratarExcecoes();
tr.ExecutarDivisao(10,0); */

/* ExerciciosArrays.Exercicio1(); */
/* ExerciciosArrays.Exercicio2(); */
/* ExerciciosArrays.Exercicio3(); */
/* ExerciciosArrays.Exercicio4(); */
/* ExerciciosArrays.Exercicio5(); */
/*  ExerciciosArrays.Exercicio6(); */
/*  ExerciciosArrays.Exercicio7(); */
/* ExerciciosArrays.Exercicio8(); */
/*  ExerciciosArrays.Exercicio9(); */
/*  ExerciciosArrays.CalculaSoma(); */


 /*  EscopoVariaveis escopo = new EscopoVariaveis();
escopo.Metodo1();
escopo.Metodo2();
escopo.Metodo3();
escopo.ExibirContadorGlobal(); */

/* TratamentoExcecoes tr = new TratamentoExcecoes();
tr.ExecutarDivisao(9,3);
TratamentoExcecoes tr1 = new TratamentoExcecoes();
tr1.ExecutarDivisao(10,0);
tr1.ExecutarDivisao(0,2); */

//ArrayExercicio.Exercicio1();
//ArrayExercicio.Exercicio2();
//ArrayExercicio.Exercicio3();
//ArrayExercicio.Exercicio4();
//ArrayExercicio.Exercicio5();

//ListExercicio.Exercicio1();
//ListExercicio.Exercicio2();
//ListExercicio.Exercicio3();
//ListExercicio.Exercicio4();


/* ExerciciosArrays exercicioArthur = new ExerciciosArrays(); */
//exercicioArthur.CalculaSoma(2,4);
//exercicioArthur.XCondicional(5);

/*  ExerciciosArrays.Carro carro = new ExerciciosArrays.Carro();
carro.marca = "Toyota";
carro.Escrever(); // Exercicio 2
carro.ConflitoEscopo(); // Exercicio 3  */

/* ExerciciosArrays.AlterandoValorVariavelGlobal(); */

/* ExerciciosArrays.Contador contador = new ExerciciosArrays.Contador();
contador.IncrementarPor10(5); */

/* ExerciciosArrays.ConversaoTipo(); */
/*  ExerciciosArrays.LancandoExcecao(-5); */

/* ParadigmasPOO conceitos = new ParadigmasPOO();

// Explicar Orientação a Objetos
conceitos.ExplicarOrientacaoAObjetos();

// Explicar a diferença entre Programação Estruturada e Orientada a Objetos
conceitos.DiferencaEntreParadigmas();

// Explicar os Pilares da Orientação a Objetos
conceitos.ExplicarPilares(); */


// 1. Criando Objetos (Instanciando a classe Pessoa)
             Pessoa pessoa1 = new Pessoa("Alice", 30);
            Pessoa pessoa2 = new Pessoa("Bob", 25);

            // 2. Usando Métodos de Instância (Métodos não estáticos)
            pessoa1.ExibirInformacoes();
            pessoa2.ExibirInformacoes();

            // 3. Usando Método Estático (Pertence à Classe, não à instância)
            Pessoa.ExibirNumeroDePessoas();

            // 4. Membros de Instância vs. Membros Estáticos
            Console.WriteLine($"Pessoa1: {pessoa1.Nome}, Idade: {pessoa1.Idade}");
            Console.WriteLine($"Pessoa2: {pessoa2.Nome}, Idade: {pessoa2.Idade}");
            Console.WriteLine($"Número total de pessoas: {Pessoa.NumeroDePessoas}");