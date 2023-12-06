O recurso Enhanced Form Navigation do Blazor no .NET 8 permite que os formulários sejam navegados de forma mais eficiente e suave melhorando a experiencia do usuario. 
Isso é feito interceptando os requests de navegação e a seguir aplicando a resposta ao DOM existente, preservando o máximo possível do estado do formulário.

**Usando o recurso**

Podemos habilitar o tratamento aprimorado de formulário, em formulários EditForm ou nos formulários HTML, que usam a tag <form>.
Nos formulários <EditForm> temos que adicionar a diretiva Enhance na definição do EditForm.

<EditForm method="post" Model="Product" OnValidSubmit="AddProduct" FormName="create" Enhance>

Nos formulários HTML podemos adicionar o atributo data-enhance no formulario:

<form data-enhance>
    <input name="query" placeholder="Procurar" value="@Query" />
    <button>Procurar</button>
</form>

**Recebendo valores via QeryString e via formulário**

Outro recurso disponível é que podemos receber o valor de parâmetros via querystring usando o atributo [SupplyParameterFromQuery] e 
também podemos obter valores do formulário usando  o atributo [SupplyParameterFromForm].

Exemplo:

   <EditForm method="post" Model=“Test" OnValidSubmit=“Add" FormName="create" Enhance>
        //... 
  </EditForm>

@code {
    [SupplyParameterFromQuery]
    public int Id { get; set; }

    [SupplyParameterFromForm]
    public Product? Product { get; set; }
  ...
}

Neste exemplo:

**[SupplyParameterFromQuery]** - Indica que o componente pode suprir o valor para o parâmetro da querystring da URL 

**[SupplyParameterFromForm]** - Indica que o valor da propriedade será fornecida a partir do formulário de dados 
