using App.Data.Repository;
using App.Domain.Dto;
using App.Domain.Entity;
using App.Domain.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Service.Services.Produto
{
    public class ProdutoService : IProdutoService
    {
        private IRepository<ProdutoEntity> _repository;
        private IRepository<FornecedorEntity> _fornecedorRepository;

        public ProdutoService()
        {
            _repository = new BaseRepository<ProdutoEntity>();
            _fornecedorRepository = new BaseRepository<FornecedorEntity>();
        }

        public bool Delete(int id)
        {
            return _repository.Delete(id);
        }

        public ProdutoEntity Get(int id)
        {
            if (id == 0)
                return new ProdutoEntity();

            return _repository.Select(id);
        }

        public IEnumerable<ProdutoEntity> GetAll()
        {
            return _repository.Select();
        }

        public IEnumerable<ProdutoDto> GetAllDto()
        {
            IEnumerable<ProdutoEntity> produtos = _repository.Select();

            foreach (ProdutoEntity produto in produtos)
            {
                yield return MapToDto(produto);
            }
        }

        public ProdutoDto GetDto(int id)
        {
            if (id == 0)
                return new ProdutoDto();

            ProdutoEntity produto = _repository.Select(id);

            if (produto == null)
                return new ProdutoDto();

            return MapToDto(produto);
        }

        ProdutoDto MapToDto(ProdutoEntity produto)
        {
            FornecedorEntity fornecedor = _fornecedorRepository.Select(produto.FornecedorId);

            return new ProdutoDto
            {
                Id = produto.Id,
                Nome = produto.Nome,
                Quantidade = produto.Quantidade,
                FornecedorId = produto.FornecedorId,
                FornecedorNome = fornecedor.Nome == null ? "" : fornecedor.Nome
            };
        }

        ProdutoEntity MapToEntity(ProdutoDto produtoDto, ProdutoEntity produtoEntity)
        {
            produtoEntity.Id = produtoDto.Id;
            produtoEntity.Nome = produtoDto.Nome;
            produtoEntity.Quantidade = produtoDto.Quantidade;
            produtoEntity.FornecedorId = produtoDto.FornecedorId;

            return produtoEntity;
        }

        public ProdutoEntity Post(ProdutoEntity produto)
        {
            return _repository.Insert(produto);
        }

        public ProdutoEntity Post(ProdutoDto produtoDto)
        {
            return _repository.Insert(MapToEntity(produtoDto, new ProdutoEntity()));
        }

        public ProdutoDto PostDto(ProdutoDto produtoDto)
        {
            ProdutoEntity produto = _repository.Insert(MapToEntity(produtoDto, new ProdutoEntity()));
            return MapToDto(produto);
        }

        public ProdutoEntity Put(ProdutoEntity produto)
        {
            return _repository.Update(produto);
        }

        public ProdutoEntity Put(ProdutoDto produtoDto)
        {
            ProdutoEntity produto = Get(produtoDto.Id);
            return _repository.Update(MapToEntity(produtoDto, produto));
        }

        public ProdutoDto PutDto(ProdutoDto produtoDto)
        {
            ProdutoEntity produto = Get(produtoDto.Id);
            produto = _repository.Update(MapToEntity(produtoDto, produto));
            return MapToDto(produto);
        }
    }
}
