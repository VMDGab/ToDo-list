<template>
    <div class="statusContainer">
        <div class="status">
            <span ref="belated" class="statusTitle" @click="selectedStatus('belated')">Behind Schedule</span>
        </div>
        <div class="status">
            <span ref="upcoming" class="statusTitle active" @click="selectedStatus('upcoming')"">Upcoming</span>
        </div>
        <div class="status">
            <span ref="completed" class="statusTitle" @click="selectedStatus('completed')"">Completed</span>
        </div>
    </div>
</template>

<script>

export default{
    name:"status",
    methods:{
        selectedStatus(status){
            switch (status){
                case 'belated':
                    this.$refs.upcoming.classList.remove("active");
                    this.$refs.completed.classList.remove("active");
                    this.$refs.belated.classList.add("active");
                    break;
                case 'upcoming':
                    this.$refs.belated.classList.remove("active");
                    this.$refs.completed.classList.remove("active");
                    this.$refs.upcoming.classList.add("active");
                    break;

                case 'completed':
                    this.$refs.upcoming.classList.remove("active");
                    this.$refs.belated.classList.remove("active");
                    this.$refs.completed.classList.add("active");
                    break;

            }

            

            
            
        }
    }
}
</script>

<style>
.statusContainer{
    display: flex;
    width: 100%;
    border-bottom:solid 1px var(--lightText);
    padding-bottom: 10px;
}
.statusTitle{
    padding-bottom: 10px;
    font-size: 14px;
    margin-right: 22px;
    font-family: var(--font);
    color: var(--text);
    font-weight: 500;
    line-height: 20px;
    letter-spacing: -0.24px;
    text-align: center;
    cursor: pointer;
    
}

.active{
    color:var(--primary);
    border-bottom:solid 3px var(--primary);
}
</style>