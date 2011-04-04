﻿using System;

namespace NHibernate.Mapping.ByCode
{
	public interface IJoinAttributesMapper : IEntitySqlsMapper
	{
		void Table(string tableName);
		void Catalog(string catalogName);
		void Schema(string schemaName);
		void Key(Action<IKeyMapper> keyMapping);
		void Inverse(bool value);
		void Optional(bool isOptional);
		void Fetch(FetchKind fetchMode);
	}

	public interface IJoinMapper : IJoinAttributesMapper, ICollectionPropertiesContainerMapper, IBasePlainPropertyContainerMapper { }

	public interface IJoinMapper<TEntity> : IJoinAttributesMapper, ICollectionPropertiesContainerMapper<TEntity>, IBasePlainPropertyContainerMapper<TEntity> 
		where TEntity : class {}
}