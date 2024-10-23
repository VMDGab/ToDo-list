<template>
    <div class="cardContainer">
        <span class="taksTitle">{{ title }}</span>
        <span ref="date" class="taskDate">{{ date }}</span>
    </div>
</template>

<script>
export default{
    name: "Card",
    props:{
        title: String,
        date: String,
        belated: Boolean,
    },
    mounted(){
        this.belatedTasks()
    },
    methods:{
        belatedTasks(){
            this.belated ? this.$refs.date.classList.add('belated') :  this.$refs.date.classList.remove('belated')
        }
    }
}
</script>

<style>

    .cardContainer{
        width: 334px;
        height: 74px;
        border-radius: 10px;
        border: .5px solid var(--lightText);
        padding: 17px 20px;
        margin-top: 20px;
        display: flex;
        flex-direction: column;
        align-items: flex-start;
        justify-content: center;
    }

    .taskTitle{
        font-family: var(--font);
        font-weight: 400;
        font-size: 14px;
        line-height: 20px;
        text-align: center;
        letter-spacing: -0.24px;
        color: var(--text);
    }
    .taskDate{
        font-family: var(--font);
        font-weight: 400;
        font-size: 12px;
        line-height: 20px;
        letter-spacing: -0.24px;
        text-align: center;
        color: var(--text); 
    }

    .belated{
        color: var(--belated);
    }



</style>