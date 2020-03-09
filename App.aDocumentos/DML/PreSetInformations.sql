--Usuário
if (not exists (select top 1 * from [Usuarios] where Login = 'Administrador'))
begin
	insert into Usuarios ([Login],[Senha],[CreatedAt])
	values ('Administrador', 'senha', getdate())
end

if (not exists (select top 1 * from [Usuarios] where Login = 'destativado'))
begin
	insert into Usuarios ([Login],[Senha],[CreatedAt],[Ativo])
	values ('desatativado', 'senha', getdate(), 0)
end


--Fornecedores

if (not exists (select top 1 * from Fornecedores where Cnpj = '000.000.000/0000-01'))
begin
	Insert into Fornecedores (Nome, Cnpj, Endereco, Ativo, CreatedAt)
	values ('Coca Cola Brasil', '000.000.000/0000-01', 'Praia de Botafogo 374', 1,GETDATE())
end;

if (not exists (select top 1 * from Fornecedores where Cnpj = '000.000.000/0000-02'))
begin
	Insert into Fornecedores (Nome, Cnpj, Endereco, Ativo, CreatedAt)
	values ('Ambev', '000.000.000/0000-02', 'Rua Dr. Renato Paes de Barro', 1,GETDATE())
end;


if (not exists (select top 1 * from Fornecedores where Cnpj = '000.000.000/0000-03'))
begin
	Insert into Fornecedores (Nome, Cnpj, Endereco, Ativo, CreatedAt)
	values ('Fornecedor 3', '000.000.000/0000-03', 'Rua Teste', 1, GETDATE())
end;


--Produtos

if (not exists (select top 1 * from [Produtos] where Nome = 'Coca Cole 1L'))
begin
	insert into [Produtos] ([Nome],[Quantidade], [FornecedorId], [CreatedAt])
	values ('Coca Cole 1L', 100,(Select Id from Fornecedores where Cnpj = '000.000.000/0000-01'), getdate())
end

if (not exists (select top 1 * from [Produtos] where Nome = 'Brahma Lata'))
begin
	insert into [Produtos] ([Nome],[Quantidade], [FornecedorId], [CreatedAt])
	values ('Brahma Lata', 500,(Select Id from Fornecedores where Cnpj = '000.000.000/0000-02'), getdate())
end
