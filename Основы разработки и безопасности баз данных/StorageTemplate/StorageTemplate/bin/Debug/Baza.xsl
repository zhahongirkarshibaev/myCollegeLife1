<?xml version="1.0" standalone="yes"?>
<xs:schema id="NewDataSet" xmlns="" xmlns:xs="http://www.w3.org/2001/XMLSchema" xmlns:msdata="urn:schemas-microsoft-com:xml-msdata">
  <xs:element name="NewDataSet" msdata:IsDataSet="true" msdata:UseCurrentLocale="true">
    <xs:complexType>
      <xs:choice minOccurs="0" maxOccurs="unbounded">
        <xs:element name="Места_x0020_хранения">
          <xs:complexType>
            <xs:sequence>
              <xs:element name="пк" msdata:DataType="System.Guid, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" msdata:ReadOnly="true" type="xs:string" default="1de7423e-75cb-42ea-a427-3bc9c64f850f" />
              <xs:element name="Место_x0020_хранения" minOccurs="0">
                <xs:simpleType>
                  <xs:restriction base="xs:string">
                    <xs:maxLength value="30" />
                  </xs:restriction>
                </xs:simpleType>
              </xs:element>
            </xs:sequence>
          </xs:complexType>
        </xs:element>
        <xs:element name="Ответственные_x0020_лица">
          <xs:complexType>
            <xs:sequence>
              <xs:element name="пк" msdata:DataType="System.Guid, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" msdata:ReadOnly="true" type="xs:string" default="194507c4-d99b-484f-abb7-bedf9d501bb3" />
              <xs:element name="Фамилия_x0020_Имя_x0020_Отчество" minOccurs="0">
                <xs:simpleType>
                  <xs:restriction base="xs:string">
                    <xs:maxLength value="50" />
                  </xs:restriction>
                </xs:simpleType>
              </xs:element>
              <xs:element name="Номер_x0020_телефона" minOccurs="0">
                <xs:simpleType>
                  <xs:restriction base="xs:string">
                    <xs:maxLength value="12" />
                  </xs:restriction>
                </xs:simpleType>
              </xs:element>
              <xs:element name="вк" msdata:DataType="System.Guid, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" msdata:ReadOnly="true" type="xs:string" />
            </xs:sequence>
          </xs:complexType>
        </xs:element>
        <xs:element name="Категории_x0020_материальных_x0020_ценностей">
          <xs:complexType>
            <xs:sequence>
              <xs:element name="пк" msdata:DataType="System.Guid, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" msdata:ReadOnly="true" type="xs:string" default="e93f7d2d-e453-451b-b217-61f161396b71" />
              <xs:element name="Наименование_x0020_категории" minOccurs="0">
                <xs:simpleType>
                  <xs:restriction base="xs:string">
                    <xs:maxLength value="35" />
                  </xs:restriction>
                </xs:simpleType>
              </xs:element>
            </xs:sequence>
          </xs:complexType>
        </xs:element>
        <xs:element name="Наименования_x0020_материальных_x0020_ценностей">
          <xs:complexType>
            <xs:sequence>
              <xs:element name="пк" msdata:DataType="System.Guid, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" msdata:ReadOnly="true" type="xs:string" default="e474eb2d-fe69-4787-b093-d66e3f30315b" />
              <xs:element name="Наименование" minOccurs="0">
                <xs:simpleType>
                  <xs:restriction base="xs:string">
                    <xs:maxLength value="50" />
                  </xs:restriction>
                </xs:simpleType>
              </xs:element>
            </xs:sequence>
          </xs:complexType>
        </xs:element>
        <xs:element name="Поставщики">
          <xs:complexType>
            <xs:sequence>
              <xs:element name="пк" msdata:DataType="System.Guid, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" msdata:ReadOnly="true" type="xs:string" default="1658cc55-7838-4d77-a9ef-6f98ba55457b" />
              <xs:element name="Наименование_x0020_поставщика" minOccurs="0">
                <xs:simpleType>
                  <xs:restriction base="xs:string">
                    <xs:maxLength value="50" />
                  </xs:restriction>
                </xs:simpleType>
              </xs:element>
              <xs:element name="Адрес" minOccurs="0">
                <xs:simpleType>
                  <xs:restriction base="xs:string">
                    <xs:maxLength value="100" />
                  </xs:restriction>
                </xs:simpleType>
              </xs:element>
              <xs:element name="Телефон" minOccurs="0">
                <xs:simpleType>
                  <xs:restriction base="xs:string">
                    <xs:maxLength value="12" />
                  </xs:restriction>
                </xs:simpleType>
              </xs:element>
              <xs:element name="Наименование_x0020_банка" minOccurs="0">
                <xs:simpleType>
                  <xs:restriction base="xs:string">
                    <xs:maxLength value="50" />
                  </xs:restriction>
                </xs:simpleType>
              </xs:element>
              <xs:element name="ИНН" minOccurs="0">
                <xs:simpleType>
                  <xs:restriction base="xs:string">
                    <xs:maxLength value="25" />
                  </xs:restriction>
                </xs:simpleType>
              </xs:element>
              <xs:element name="БИК" minOccurs="0">
                <xs:simpleType>
                  <xs:restriction base="xs:string">
                    <xs:maxLength value="15" />
                  </xs:restriction>
                </xs:simpleType>
              </xs:element>
              <xs:element name="Расчётный_x0020_счёт" minOccurs="0">
                <xs:simpleType>
                  <xs:restriction base="xs:string">
                    <xs:maxLength value="25" />
                  </xs:restriction>
                </xs:simpleType>
              </xs:element>
              <xs:element name="Корр._x0020_счёт" minOccurs="0">
                <xs:simpleType>
                  <xs:restriction base="xs:string">
                    <xs:maxLength value="25" />
                  </xs:restriction>
                </xs:simpleType>
              </xs:element>
            </xs:sequence>
          </xs:complexType>
        </xs:element>
        <xs:element name="Получатели">
          <xs:complexType>
            <xs:sequence>
              <xs:element name="пк" msdata:DataType="System.Guid, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" msdata:ReadOnly="true" type="xs:string" default="51e8b064-8136-49b0-b3ee-db0a2fb8296a" />
              <xs:element name="Наименование_x0020_получателя" minOccurs="0">
                <xs:simpleType>
                  <xs:restriction base="xs:string">
                    <xs:maxLength value="50" />
                  </xs:restriction>
                </xs:simpleType>
              </xs:element>
              <xs:element name="Адрес" minOccurs="0">
                <xs:simpleType>
                  <xs:restriction base="xs:string">
                    <xs:maxLength value="100" />
                  </xs:restriction>
                </xs:simpleType>
              </xs:element>
              <xs:element name="Телефон" minOccurs="0">
                <xs:simpleType>
                  <xs:restriction base="xs:string">
                    <xs:maxLength value="12" />
                  </xs:restriction>
                </xs:simpleType>
              </xs:element>
              <xs:element name="Наименование_x0020_банка" minOccurs="0">
                <xs:simpleType>
                  <xs:restriction base="xs:string">
                    <xs:maxLength value="50" />
                  </xs:restriction>
                </xs:simpleType>
              </xs:element>
              <xs:element name="ИНН" minOccurs="0">
                <xs:simpleType>
                  <xs:restriction base="xs:string">
                    <xs:maxLength value="25" />
                  </xs:restriction>
                </xs:simpleType>
              </xs:element>
              <xs:element name="БИК" minOccurs="0">
                <xs:simpleType>
                  <xs:restriction base="xs:string">
                    <xs:maxLength value="15" />
                  </xs:restriction>
                </xs:simpleType>
              </xs:element>
              <xs:element name="Расчётный_x0020_счёт" minOccurs="0">
                <xs:simpleType>
                  <xs:restriction base="xs:string">
                    <xs:maxLength value="25" />
                  </xs:restriction>
                </xs:simpleType>
              </xs:element>
              <xs:element name="Корр._x0020_счёт" minOccurs="0">
                <xs:simpleType>
                  <xs:restriction base="xs:string">
                    <xs:maxLength value="25" />
                  </xs:restriction>
                </xs:simpleType>
              </xs:element>
            </xs:sequence>
          </xs:complexType>
        </xs:element>
        <xs:element name="Единицы_x0020_измерения">
          <xs:complexType>
            <xs:sequence>
              <xs:element name="пк" msdata:DataType="System.Guid, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" msdata:ReadOnly="true" type="xs:string" default="7b010ace-0918-4147-aabc-a02fc66f5fb7" />
              <xs:element name="Единица_x0020_измерения" minOccurs="0">
                <xs:simpleType>
                  <xs:restriction base="xs:string">
                    <xs:maxLength value="25" />
                  </xs:restriction>
                </xs:simpleType>
              </xs:element>
            </xs:sequence>
          </xs:complexType>
        </xs:element>
        <xs:element name="Учёт_x0020_выдачи">
          <xs:complexType>
            <xs:sequence>
              <xs:element name="пк" msdata:DataType="System.Guid, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" msdata:ReadOnly="true" type="xs:string" />
              <xs:element name="вк" msdata:DataType="System.Guid, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" msdata:ReadOnly="true" type="xs:string" />
              <xs:element name="Количество" type="xs:decimal" minOccurs="0" />
              <xs:element name="Цена" type="xs:decimal" minOccurs="0" />
              <xs:element name="Сумма" type="xs:decimal" minOccurs="0" />
            </xs:sequence>
          </xs:complexType>
        </xs:element>
        <xs:element name="Учёт_x0020_списания">
          <xs:complexType>
            <xs:sequence>
              <xs:element name="вк" msdata:DataType="System.Guid, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" msdata:ReadOnly="true" type="xs:string" />
              <xs:element name="Количество" type="xs:decimal" minOccurs="0" />
              <xs:element name="Цена" type="xs:decimal" minOccurs="0" />
              <xs:element name="Сумма" type="xs:decimal" minOccurs="0" />
            </xs:sequence>
          </xs:complexType>
        </xs:element>
        <xs:element name="Учёт_x0020_материальных_x0020_ценностей">
          <xs:complexType>
            <xs:sequence>
              <xs:element name="пк" msdata:DataType="System.Guid, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" msdata:ReadOnly="true" type="xs:string" default="7384af39-ba82-4061-a0dc-a2e44d0894ef" />
              <xs:element name="вк" msdata:DataType="System.Guid, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" msdata:ReadOnly="true" type="xs:string" />
              <xs:element name="вк1" msdata:DataType="System.Guid, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" msdata:ReadOnly="true" type="xs:string" />
              <xs:element name="вк2" msdata:DataType="System.Guid, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" msdata:ReadOnly="true" type="xs:string" />
              <xs:element name="вк3" msdata:DataType="System.Guid, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" msdata:ReadOnly="true" type="xs:string" />
              <xs:element name="вк4" msdata:DataType="System.Guid, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" msdata:ReadOnly="true" type="xs:string" />
              <xs:element name="Количество" type="xs:decimal" minOccurs="0" />
              <xs:element name="Закупочная_x0020_цена" type="xs:decimal" minOccurs="0" />
              <xs:element name="Розничная_x0020_цена" type="xs:decimal" minOccurs="0" />
              <xs:element name="Сумма_x0020_закупки" type="xs:decimal" minOccurs="0" />
              <xs:element name="Сумма_x0020_розницы" type="xs:decimal" minOccurs="0" />
              <xs:element name="Дата_x0020_поступления" type="xs:dateTime" minOccurs="0" />
            </xs:sequence>
          </xs:complexType>
        </xs:element>
      </xs:choice>
    </xs:complexType>
    <xs:unique name="Constraint1" msdata:PrimaryKey="true">
      <xs:selector xpath=".//Места_x0020_хранения" />
      <xs:field xpath="пк" />
    </xs:unique>
    <xs:unique name="Ответственные_x0020_лица_Constraint1" msdata:ConstraintName="Constraint1" msdata:PrimaryKey="true">
      <xs:selector xpath=".//Ответственные_x0020_лица" />
      <xs:field xpath="пк" />
    </xs:unique>
    <xs:unique name="Категории_x0020_материальных_x0020_ценностей_Constraint1" msdata:ConstraintName="Constraint1" msdata:PrimaryKey="true">
      <xs:selector xpath=".//Категории_x0020_материальных_x0020_ценностей" />
      <xs:field xpath="пк" />
    </xs:unique>
    <xs:unique name="Наименования_x0020_материальных_x0020_ценностей_Constraint1" msdata:ConstraintName="Constraint1" msdata:PrimaryKey="true">
      <xs:selector xpath=".//Наименования_x0020_материальных_x0020_ценностей" />
      <xs:field xpath="пк" />
    </xs:unique>
    <xs:unique name="Поставщики_Constraint1" msdata:ConstraintName="Constraint1" msdata:PrimaryKey="true">
      <xs:selector xpath=".//Поставщики" />
      <xs:field xpath="пк" />
    </xs:unique>
    <xs:unique name="Получатели_Constraint1" msdata:ConstraintName="Constraint1" msdata:PrimaryKey="true">
      <xs:selector xpath=".//Получатели" />
      <xs:field xpath="пк" />
    </xs:unique>
    <xs:unique name="Единицы_x0020_измерения_Constraint1" msdata:ConstraintName="Constraint1" msdata:PrimaryKey="true">
      <xs:selector xpath=".//Единицы_x0020_измерения" />
      <xs:field xpath="пк" />
    </xs:unique>
    <xs:unique name="Учёт_x0020_материальных_x0020_ценностей_Constraint1" msdata:ConstraintName="Constraint1" msdata:PrimaryKey="true">
      <xs:selector xpath=".//Учёт_x0020_материальных_x0020_ценностей" />
      <xs:field xpath="пк" />
    </xs:unique>
    <xs:keyref name="naimuchcon" refer="Наименования_x0020_материальных_x0020_ценностей_Constraint1" msdata:RelationName="naimuch">
      <xs:selector xpath=".//Учёт_x0020_материальных_x0020_ценностей" />
      <xs:field xpath="вк" />
    </xs:keyref>
    <xs:keyref name="postuchcon" refer="Поставщики_Constraint1" msdata:RelationName="postuch">
      <xs:selector xpath=".//Учёт_x0020_материальных_x0020_ценностей" />
      <xs:field xpath="вк" />
    </xs:keyref>
    <xs:keyref name="katuchcon" refer="Категории_x0020_материальных_x0020_ценностей_Constraint1" msdata:RelationName="katuch">
      <xs:selector xpath=".//Учёт_x0020_материальных_x0020_ценностей" />
      <xs:field xpath="вк" />
    </xs:keyref>
    <xs:keyref name="oluccon" refer="Ответственные_x0020_лица_Constraint1" msdata:RelationName="oluc">
      <xs:selector xpath=".//Учёт_x0020_материальных_x0020_ценностей" />
      <xs:field xpath="вк" />
    </xs:keyref>
    <xs:keyref name="mhuchcon" refer="Constraint1" msdata:RelationName="mhuch">
      <xs:selector xpath=".//Учёт_x0020_материальных_x0020_ценностей" />
      <xs:field xpath="вк" />
    </xs:keyref>
    <xs:keyref name="uchspcon" refer="Учёт_x0020_материальных_x0020_ценностей_Constraint1" msdata:RelationName="uchsp">
      <xs:selector xpath=".//Учёт_x0020_списания" />
      <xs:field xpath="вк" />
    </xs:keyref>
    <xs:keyref name="uchvydcon" refer="Учёт_x0020_материальных_x0020_ценностей_Constraint1" msdata:RelationName="uchvyd">
      <xs:selector xpath=".//Учёт_x0020_выдачи" />
      <xs:field xpath="вк" />
    </xs:keyref>
    <xs:keyref name="polvydcon" refer="Получатели_Constraint1" msdata:RelationName="polvyd">
      <xs:selector xpath=".//Учёт_x0020_выдачи" />
      <xs:field xpath="пк" />
    </xs:keyref>
    <xs:keyref name="mholcon" refer="Constraint1" msdata:RelationName="mhol">
      <xs:selector xpath=".//Ответственные_x0020_лица" />
      <xs:field xpath="вк" />
    </xs:keyref>
  </xs:element>
</xs:schema>