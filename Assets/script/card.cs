public class card
{
    public string name;
    public int id;
    public card(string _name, int _id)
    {
        this.name = _name;
        this.id = _id;
    }
}
public class Foundation_card : card//������
{
    public void effect()//Ч��
    {

    }
    public string Description;//����
    public Foundation_card(string _name, int _id, string _description) : base(_name, _id)
    {
        this.Description = _description;
    }
}
public class Id_card : card//�����
{
    public string identify;
    public Id_card(string _name, int _id, string _identify) : base(_name, _id)
    {
        this.identify = _identify;
    }
}
public class Character_card : card //��ɫ��
{
    public string skill;
    public int hp;
    public Character_card(string _name, int _id, string _skill, int _hp) : base(_name, _id)
    {
        this.skill = _skill;
        this.hp = _hp;
    }
}

public class Talent_card : card//�츳��
{
    public int cd;
    public string description;
    public void Effect()
    {

    }
    public Talent_card(string _name, int _id, int _cd, string _description) : base(_name, _id)
    {
        this.cd = _cd;
        this.description = _description;
    }
}

public class Function_card : card//������
{
    public string description;//����
    public int number;
    public void Effect()
    {

    }
    public Function_card(string _name, int _id, string _description) : base(_name, _id)
    {
        this.description = _description;
    }
}
public class Equipment_card : card//װ����
{
    public string description;
    public void effect()
    {

    }
    public Equipment_card(string _name, int _id, string _description) : base(_name, _id)
    {
        this.description = _description;
    }

}

