﻿Public NotInheritable Class TelaInicial

    'TODO: Este formulário pode ser facilmente configurado como a tela inicial da aplicação através da edição da aba "Aplicação"
    '  no Designer de Projeto ("Propriedades" dentro do menu "Projetos").


    Sub New()

        ' Esta chamada é requerida pelo designer.
        InitializeComponent()

        ' Adicione qualquer inicialização após a chamada InitializeComponent().

    End Sub

    Private Sub TelaInicial_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ''Configura o texto do diálogo em tempo de execução de acordo com a informação do assembly da aplicação.  

        ''TODO: Personalize a informação do assembly da aplicação no painel "Aplicação" do diálogo 
        ''  propriedades do projeto (dentro do menu "Project").

        ''Título da Aplicação
        'If My.Application.Info.Title <> "" Then
        '    '  ApplicationTitle.Text = My.Application.Info.Title
        'Else
        '    '    'Se o título da aplicação estiver faltando, utiliza o nome da aplicação sem a extensão
        '    ApplicationTitle.Text = System.IO.Path.GetFileNameWithoutExtension(My.Application.Info.AssemblyName)
        'End If

        ''Formata a informação de versão utilizando o texto configurado no controlador de Versão em tempo de design como a
        ''  cadeia de caractere de formatação.  Isto facilita uma localização efetiva quando necessário.
        ''  Informação de compilação e revisão poderiam ser incluídos utilizando o seguinte código e modificando o 
        ''  texto designtime do controle de versão para "Versão {0}.{1:00}.{2}.{3}" ou algo similar.  Verifique
        ''  String.Format() na Ajuda para mais informação.
        '
        '    Version.Text = System.String.Format(Version.Text, My.Application.Info.Version.Major, My.Application.Info.Version.Minor, My.Application.Info.Version.Build, My.Application.Info.Version.Revision)

        Version.Text = System.String.Format(Version.Text, My.Application.Info.Version.Major, My.Application.Info.Version.Minor)

        'Informação de Copyright
        Copyright.Text = My.Application.Info.Copyright & " Marcos Ferreira"


    End Sub


End Class
